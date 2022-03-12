import { Injectable } from '@angular/core';
import { from, map, of } from 'rxjs';
import {
    Auth,
    authState,
    fetchSignInMethodsForEmail,
    linkWithPopup,
    unlink
} from '@angular/fire/auth';
import { AuthProvider, GithubAuthProvider, GoogleAuthProvider } from 'firebase/auth';
import { idToken } from 'rxfire/auth';
import { Router } from '@angular/router';
import { NotificationService } from '@core/services/notification.service';
import { UserService } from "@core/services/user.service";
import { User } from "@core/models/user/user";
import { EventService } from "@core/services/event.service";
import { Provider } from "@shared/constants/provider";

@Injectable({
    providedIn: 'root',
})
export class AuthService {
    currentUser$ = authState(this.auth);
    private user: User;

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

    getAuth() {
        return this.auth;
    }

    getCurrentUser() {
        return this.user
            ? of(this.user)
            : this.userService.getCurrent(this.auth.currentUser?.uid!)
                .pipe(
                    map((resp) => {
                        this.user = resp.body!;
                        this.eventService.userChanged(this.user);
                        return this.user;
                    }));
    }

    setUser(user: User) {
        this.user = user;
        this.eventService.userChanged(this.user);
    }

    logOut() {
        return from(this.auth.signOut().then(() => {
            localStorage.removeItem('jwt');
            this.user = undefined!;
            this.eventService.userChanged(undefined!);
        }));
    }

    linkProvider(providerId: Provider) {
        let provider: AuthProvider;
        switch (providerId) {
            case Provider.google: {
                provider = new GoogleAuthProvider().setCustomParameters({
                    prompt: "select_account"
                });
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

    getAuthIdToken() {
        return from(idToken(this.auth));
    }
}
