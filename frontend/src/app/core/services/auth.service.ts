import { Injectable } from '@angular/core';
import { from, map, of } from 'rxjs';
import {
    Auth,
    authState,
    linkWithPopup,
    unlink,
} from '@angular/fire/auth';
import { GithubAuthProvider, GoogleAuthProvider } from 'firebase/auth';
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

    getCurrentUser() {
        return this.user
            ? of(this.user)
            : this.userService.getCurrent(this.auth.currentUser?.uid!)
                .pipe(
                    map((user) => {
                        this.user = user;
                        this.eventService.userChanged(this.user);
                        return this.user;
                    }));
    }

    setUser(user: User) {
        this.user = user;
        this.eventService.userChanged(this.user);
    }

    logOut() {
        localStorage.removeItem('jwt');
        this.user = undefined!;
        this.eventService.userChanged(undefined!);
        return this.auth.signOut();
    }

    linkProvider(providerId: Provider) {
        let provider = this.getProvider(providerId);
        return from(linkWithPopup(this.auth.currentUser!, provider)
            .then(() => {
                this.notificationService.showSuccessMessage(`${provider.providerId} was linked`, 'Success');
            })
            .catch(err => {
                this.notificationService.showErrorMessage('This account is already added to Codi!', 'Error');
            }));
    }

    getProvider(providerId: Provider) {
        switch (providerId) {
            case Provider.google: {
                return new GoogleAuthProvider().setCustomParameters({
                    prompt: "select_account"
                });

            }
            case Provider.github: {
                return new GithubAuthProvider();
            }
        }
    }

    unlinkProvider(providerId: Provider) {
        return from(unlink(this.auth.currentUser!, providerId)
            .then(() => {
                this.notificationService.showSuccessMessage(`${providerId} was unlinked`, 'Success');
            }));
    }

    getLinkedProviders() {
        return of(this.auth.currentUser?.providerData
            .map((data) => data.providerId));
    }

    getAuthIdToken() {
        return from(idToken(this.auth));
    }

    getAuthIdTokenPromise() {
        return this.auth.currentUser!.getIdToken();
    }
}
