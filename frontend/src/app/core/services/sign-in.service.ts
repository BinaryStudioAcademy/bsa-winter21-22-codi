import { Injectable } from '@angular/core';
import { GithubAuthProvider, GoogleAuthProvider } from "firebase/auth";
import {
    fetchSignInMethodsForEmail,
    signInWithEmailAndPassword,
    signInWithPopup,
    UserCredential,
    OAuthCredential,
    OAuthProvider, Auth
} from "@angular/fire/auth";
import { from, take } from "rxjs";
import { AuthService } from "@core/services/auth.service";
import { UserService } from "@core/services/user.service";
import { Router } from "@angular/router";
import { NotificationService } from "@core/services/notification.service";
import { RegistrationService } from "@core/services/registration.service";
import { ConfirmationDialogService } from "@core/services/confirmation-dialog.service";
import { User } from "@core/models/user/user";

@Injectable({
    providedIn: 'root'
})
export class SignInService {

    constructor(
        private auth: Auth,
        private authService: AuthService,
        private userService: UserService,
        private registrationService: RegistrationService,
        private notificationService: NotificationService,
        private router: Router,
        private confirmationDialogService: ConfirmationDialogService
    ) { }

    signInWithGithub(redirectUrl?: string) {
        const githubProvider = new GithubAuthProvider();
        return signInWithPopup(this.auth, githubProvider).then(
            (credential) => {
                this.loginWithProviders(credential, redirectUrl);
            }
        )
            .catch((error) => {
                this.openSignInWarning(error);
            });
    }

    signInWithGoogle(redirectUrl?: string) {
        let googleProvider = new GoogleAuthProvider()
            .setCustomParameters({
                prompt: 'select_account'
            });
        return signInWithPopup(this.auth, googleProvider).then(
            (credential) => {
                this.loginWithProviders(credential, redirectUrl);
            }
        )
            .catch((error) => {
                this.openSignInWarning(error);
            });
    }

    openSignInWarning(error: any) {
        let pendingCredential = OAuthProvider.credentialFromResult(
            error.customData
        ) as OAuthCredential;
        let availableProviders: string = '';
        fetchSignInMethodsForEmail(this.auth, error.customData.email)
            .then((providers => {
                availableProviders = providers.toString().replace(',', ' or ');
                switch (error.code) {
                    case 'auth/account-exists-with-different-credential': {
                        this.showExistsAccountDialog(pendingCredential.providerId, availableProviders);
                        break;
                    }
                    case 'auth/cancelled-popup-request': break;
                }
            }));
    }

    showExistsAccountDialog(pendingProvider: string, availableProviders: string) {
        this.confirmationDialogService
            .openConfirmationDialog(
                ``,
                `It seems that you would like to login with ${pendingProvider},
                                but you've already had an account in Codi.
                                To make it possible, firstly, login with ${availableProviders ? availableProviders : 'google.com'}
                                and link with ${pendingProvider} in user settings.`,
                {
                    cancelButton: false,
                    centered: true
                }
            );
    }

    openVerificationEmailRemembering(email: string) {
        this.authService.logOut().then(() => {
            this.confirmationDialogService
                .openConfirmationDialog(
                    `Verify your Email`,
                    `It seems that your email is not verified. We sent a verification letter to ${email}. To continue studying with
                        us check it out and verify it now!`,
                    {
                        cancelButton: false,
                        centered: true
                    }
                );
        })
    }

    loginWithProviders(credential: UserCredential, redirectUrl?: string): void {
        this.userService.getCurrent(credential.user.uid)
            .subscribe((user) => {
                if (user) {
                    this.setUserIfVerifiedEmail(credential.user?.email!, user);
                }
                else {
                    this.registrationService.signUpWithProviders(credential);
                }
            }, (error) => {
                this.registrationService.signUpWithProviders(credential);
            });
    }

    setUserIfVerifiedEmail(email: string, currentUser: User) {
        this.authService.currentUser$
            .pipe(take(1))
            .subscribe((user) => {
                if(user){
                    if (!user?.emailVerified) {
                        this.openVerificationEmailRemembering(email);
                    }
                    else {
                        this.router.navigate(['main']).then(() => {
                            this.notificationService.showSuccessMessage('You have successfully logged in', 'Welcome back!');
                        });
                        this.authService.setUser(currentUser);
                    }
                }
            });
    }

    signIn(email: string, password: string) {
        return from(signInWithEmailAndPassword(this.auth, email, password).then((credential) => {
            if(!credential.user.emailVerified){
                this.openVerificationEmailRemembering(credential.user?.email!);
            }
            else{
                this.router.navigate(['main']).then(() => {
                    this.notificationService.showSuccessMessage('You have successfully logged in', 'Welcome back!');
                });
            }
        })
            .catch(
                (error) => {
                    this.showErrorSignInMessage(error);
                }
            ))
    }

    showErrorSignInMessage(error: any) {
        switch(error.code) {
            case 'auth/wrong-password':
                this.notificationService.showErrorMessage('The email address or password is incorrect', 'Error');
                break;
            case 'auth/user-not-found':
                this.notificationService.showErrorMessage('Invalid email or password. Please try again', 'Error');
                break;
            default:
                this.notificationService.showErrorMessage(error.code, 'Error');
                break;
        }
    }
}
