import { Injectable } from '@angular/core';
import {from, Subject, takeUntil} from "rxjs";
import {
    createUserWithEmailAndPassword,
    UserCredential
} from "@angular/fire/auth";
import { AuthService } from "@core/services/auth.service";
import { UserService } from "@core/services/user.service";
import { NotificationService } from "@core/services/notification.service";
import { Router } from "@angular/router";
import { CreateUser } from "@core/models/user/create-user";

@Injectable({
  providedIn: 'root'
})
export class RegistrationService {
    private unsubscribe$ = new Subject<void>();

    constructor(
        private authService: AuthService,
        private userService: UserService,
        private notificationService: NotificationService,
        private router: Router
    ) { }

    signUpWithGoogle(credential: UserCredential) {
        let newUser = {
            firebaseId: credential.user.uid,
            email: credential.user.email
        } as CreateUser;
        this.saveUser(newUser);
        this.router.navigate(['main']).then(() => {
            this.notificationService.showSuccessMessage('You have successfully register', 'Congratulate!');
        });
    }

    signUpWithGithub(credential: UserCredential) {
        let newUser = {
            firebaseId: credential.user.uid,
            email: credential.user.email,
            username: credential.user.displayName
        } as CreateUser;
        this.saveUser(newUser);
    }

    signUpWithProviders(credential: UserCredential) {
        let provider = credential.providerId;
        switch (provider) {
            case 'google.com': {
                this.signUpWithGoogle(credential);
                break;
            }
            case 'github.com': {
                this.signUpWithGithub(credential);
                break;
            }
        }
    }

    signUp(username: string, email: string, password: string) {
        return from(createUserWithEmailAndPassword(this.authService.getAuth(), email, password)
            .then((credential) => {
                let newUser = {
                    firebaseId: credential.user.uid,
                    email: credential.user.email,
                    username: username
                } as CreateUser;
                this.saveUser(newUser);
                this.authService.logOut();
                this.router.navigate(['login'])
                    .then(() => this.notificationService.showSuccessMessage('You have successfully register', 'Congratulate!'));
            })
            .catch(
                (error) => {
                    switch(error.code) {
                        case 'auth/email-already-in-use':
                            this.notificationService.showErrorMessage('Email already in use', 'Error');
                            break;
                        default:
                            this.notificationService.showErrorMessage(error.code, 'Error');
                            break;
                    }
                }
            )
        );
    }

    saveUser(newUser: CreateUser) {
        this.userService
            .create(newUser)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((user) => {
                this.authService.setUser(user.body!);
            });
    }
}
