import { Injectable } from '@angular/core';
import { from, Subject, takeUntil } from "rxjs";
import {
    Auth,
    createUserWithEmailAndPassword, sendEmailVerification,
    UserCredential
} from "@angular/fire/auth";
import { AuthService } from "@core/services/auth.service";
import { UserService } from "@core/services/user.service";
import { NotificationService } from "@core/services/notification.service";
import { Router } from "@angular/router";
import { CreateUser } from "@core/models/user/create-user";
import { ConfirmationDialogService } from "@core/services/confirmation-dialog.service";

@Injectable({
    providedIn: 'root'
})
export class RegistrationService {
    private unsubscribe$ = new Subject<void>();

    constructor(
        private auth: Auth,
        private authService: AuthService,
        private userService: UserService,
        private notificationService: NotificationService,
        private router: Router,
        private confirmationDialogService: ConfirmationDialogService
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
        this.navigateToConfirmEmail(credential);
    }

    signUpWithProviders(credential: UserCredential) {
        switch (credential.providerId) {
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
        return from(createUserWithEmailAndPassword(this.auth, email, password)
            .then((credential) => {
                let newUser = {
                    firebaseId: credential.user.uid,
                    email: credential.user.email,
                    username: username
                } as CreateUser;
                this.saveUser(newUser);
                this.navigateToConfirmEmail(credential);
            })
            .catch(
                (error) => {
                    this.showErrorSignUpMessage(error);
                }
            )
        );
    }

    showErrorSignUpMessage(error: any) {
        switch(error.code) {
            case 'auth/email-already-in-use':
                this.notificationService.showErrorMessage('Email already in use', 'Error');
                break;
            default:
                this.notificationService.showErrorMessage(error.code, 'Error');
                break;
        }
    }

    saveUser(newUser: CreateUser) {
        this.userService
            .create(newUser)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((user) => {
                this.authService.setUser(user);
            });
    }

    async navigateToConfirmEmail(credential: UserCredential) {
        await this.authService.logOut();
        await sendEmailVerification(credential.user)
        await this.router.navigate(['login'])

        this.openVerificationEmail(credential.user?.email!);
    }

    openVerificationEmail(email: string) {
        this.confirmationDialogService
            .openConfirmationDialog(
                `Thanks for the registration!`,
                `Your account has been created and a verification email has been sent
                    to ${email}. Please click on the verification link included in the email
                    to activate your account.`,
                {
                    cancelButton: false,
                    centered: true
                }
            );
    }
}
