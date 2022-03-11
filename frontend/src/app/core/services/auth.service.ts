import { Injectable } from '@angular/core';
import { from, map, of, Subject, switchMap, takeUntil } from 'rxjs';
import {
    Auth,
    authState,
    createUserWithEmailAndPassword,
    fetchSignInMethodsForEmail, getAuth,
    linkWithPopup,
    signInWithEmailAndPassword,
    signInWithPopup,
    unlink,
    updateProfile
} from '@angular/fire/auth';
import { AuthProvider, GithubAuthProvider, GoogleAuthProvider } from 'firebase/auth';
import { idToken } from 'rxfire/auth';
import { Router } from '@angular/router';
import { NotificationService } from '@core/services/notification.service';
import { UserService } from "@core/services/user.service";
import { User } from "@core/models/user/user";
import { CreateUser } from "@core/models/user/create-user";
import { EventService } from "@core/services/event.service";
import { Provider } from "@shared/constants/provider";

@Injectable({
    providedIn: 'root',
})
export class AuthService {
    currentUser$ = authState(this.auth);

    private user: User;
    private unsubscribe$ = new Subject<void>();

    constructor(
        private auth: Auth,
        private router: Router,
        private notificationService: NotificationService,
        private userService: UserService,
        private eventService: EventService
    ) {
        this.currentUser$.subscribe(user => {
            if (user) {
                user.getIdToken(true).then(token => {
                    localStorage.setItem('jwt', token)
                });
            }
        })
    }

    saveUser(uid: string, email?: string, username?: string) {
        let user =  {
            firebaseId: uid,
            email: email,
            username: username
        } as CreateUser;
        this.userService
            .create(user)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((user) => {
                this.user = user.body!;
            })
    }

    getCurrentUser() {
        return this.user
            ? of(this.user)
            : this.currentUser$
                .pipe(
                    switchMap((userResp) => this.userService.getCurrent(userResp?.uid!)
                        .pipe(
                            map((resp) => {
                                this.user = resp.body!;
                                this.eventService.userChanged(this.user);
                                return this.user;
                            }))
                    ))
    }

    setUser(user: User) {
        this.user = user;
        this.eventService.userChanged(this.user);
    }

    signUp(username: string, email: string, password: string) {
        return from(createUserWithEmailAndPassword(this.auth, email, password)
            .then((credential) => {
                this.saveUser(credential.user.uid, email, username);
                updateProfile(credential.user, {displayName: username})
                    .then(() => {
                        this.router.navigate(['main'])
                            .then(() => this.notificationService.showSuccessMessage('You have successfully register', 'Welcome back!'))
                    })})
            .catch((error) => this.notificationService.showErrorMessage(this.formatError(error.code), 'Error'))
        );
    }

    signIn(email: string, password: string) {
        return from(signInWithEmailAndPassword(this.auth, email, password).then(() => {
            this.router.navigate(['main']).then(() => {
                this.notificationService.showSuccessMessage('You have successfully logged in', 'Welcome back!');
            });
        })
            .catch((error) => {
                this.notificationService.showErrorMessage(this.formatError(error.code), 'Error');
            }));
    }

    logOut() {
        return from(this.auth.signOut().then(() => {
            this.router.navigate(['login']).then(() => {
                this.notificationService.showSuccessMessage('Good Luck!');
            });
            localStorage.removeItem('jwt');
            this.user = undefined!;
            this.eventService.userChanged(undefined!);
        }));
    }

    withGoogle() {
        return from(this.authLogin(new GoogleAuthProvider())).subscribe((r) => {
            let user = r.user;
            this.saveUser(user.uid, user.email!);
            this.router.navigate(['main']).then(() => {
                this.notificationService.showSuccessMessage('You have successfully logged in', 'Welcome back!');
            })
        },
        error => {
            if(error.code !== 'auth/popup-closed-by-user' )
                this.notificationService.showErrorMessage(this.formatError(error.code), 'Error');
        });
    }

    withGitHub() {
        let githubProvider = new GithubAuthProvider();
        return from(this.authLogin(githubProvider)).subscribe((r) => {
            let user = r.user;
            this.saveUser(user.uid, user.email!);
            this.router.navigate(['main']).then(() => {
                this.notificationService.showSuccessMessage('You have successfully logged in', 'Welcome back!');
            })
        },
        error => {
            if(error.code !== 'auth/popup-closed-by-user' )
                this.notificationService.showErrorMessage(this.formatError(error.code), 'Error');
        });
    }

    linkProvider(providerId: Provider) {
        let provider: AuthProvider;
        switch (providerId) {
            case Provider.google: {
                provider = new GoogleAuthProvider();
                break;
            }
            case Provider.github: {
                provider = new GithubAuthProvider();
                break;
            }
        }
            return from(linkWithPopup(this.auth.currentUser!, provider!)
                .then(() => {
                    this.notificationService.showSuccessMessage(`${provider.providerId} was successfully linked`);
                })
                .catch(err => {
                    this.notificationService.showErrorMessage('This account is already added to Codi!');
                }));
    }

    unlinkProvider(providerId: Provider) {
        return from(unlink(this.auth.currentUser!, providerId)
            .then(() => {
                this.notificationService.showSuccessMessage(`${providerId} was successfully unlinked`);
            }));
    }

    getLinkedProviders() {
        return from(fetchSignInMethodsForEmail(this.auth, this.auth.currentUser?.email!));
    }

    authLogin(provider: AuthProvider) {
        return from(signInWithPopup(this.auth, provider));
    }

    getAuthIdToken() {
        return from(idToken(this.auth));
    }

    formatError(errorCode: string): string {
        const errorParts = errorCode.split('/');
        errorParts.shift();
        const allNeedForError = errorParts.join('/').replace(/-/g, ' ').toUpperCase();
        return allNeedForError;
    }
}
