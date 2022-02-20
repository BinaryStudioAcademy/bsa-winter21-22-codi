import { Injectable } from '@angular/core';
import { from, map, of, Subject, switchMap, takeUntil } from 'rxjs';
import { Auth, authState, createUserWithEmailAndPassword,
    signInWithEmailAndPassword, signInWithPopup, updateProfile } from '@angular/fire/auth';
import { GoogleAuthProvider, GithubAuthProvider, AuthProvider } from 'firebase/auth';
import { idToken } from 'rxfire/auth';
import { Router } from '@angular/router';
import { NotificationService } from '@core/services/notification.service';
import { UserService } from "@core/services/user.service";
import { User } from "@core/models/user/user";
import { CreateUser } from "@core/models/user/create-user";

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
    private userService: UserService
    ) {
    this.currentUser$.subscribe(user => {
      if (user) {
        this.userService
          .create({email: user.email} as CreateUser)
          .pipe(takeUntil(this.unsubscribe$))
          .subscribe((user) => {
            this.user = user.body!;
          })
        user.getIdToken(true).then(token => {
          localStorage.setItem('jwt', token)
        });
      }
    })
    }

getCurrentUser() {
    return this.user
        ? of(this.user)
        : this.currentUser$
            .pipe(
                switchMap((userResp) => this.userService.getCurrent(userResp?.email!)
                    .pipe(
                        map((resp) => {
                            this.user = resp.body!;
                            return this.user;
                        }))
                ))
}

public setUser(user: User) {
    this.user = user;
}

    signUp(username: string, email: string, password: string) {
        return from(createUserWithEmailAndPassword(this.auth, email, password)
            .then((credential) => {
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
        }));
    }

    withGoogle() {
        return from(this.authLogin(new GoogleAuthProvider())).subscribe(() => {
            this.router.navigate(['main']).then(() => {
                this.notificationService.showSuccessMessage('You have successfully logged in', 'Welcome back!');
            })
                .catch((error) => {
                    this.notificationService.showErrorMessage(this.formatError(error.code), 'Error');
                });
        });
    }

    withGitHub() {
        return from(this.authLogin(new GithubAuthProvider())).subscribe(() => {
            this.router.navigate(['main']).then(() => {
                this.notificationService.showSuccessMessage('You have successfully logged in', 'Welcome back!');
            })
                .catch((error) => {
                    this.notificationService.showErrorMessage(this.formatError(error.code), 'Error');
                });
        });
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
