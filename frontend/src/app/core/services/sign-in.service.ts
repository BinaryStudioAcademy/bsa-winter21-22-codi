import { Injectable } from '@angular/core';
import { GithubAuthProvider, GoogleAuthProvider } from "firebase/auth";
import {
    fetchSignInMethodsForEmail,
    sendEmailVerification,
    signInWithEmailAndPassword,
    signInWithPopup,
    UserCredential,
    OAuthCredential,
    OAuthProvider
} from "@angular/fire/auth";
import { from } from "rxjs";
import { AuthService } from "@core/services/auth.service";
import { UserService } from "@core/services/user.service";
import { Router } from "@angular/router";
import { NotificationService } from "@core/services/notification.service";
import { RegistrationService } from "@core/services/registration.service";
import { ConfirmationDialogService } from "@core/services/confirmation-dialog.service";

@Injectable({
    providedIn: 'root'
})
export class SignInService {

    constructor(
        private authService: AuthService,
        private userService: UserService,
        private registrationService: RegistrationService,
        private notificationService: NotificationService,
        private router: Router,
        private confirmationDialogService: ConfirmationDialogService
    ) { }

    signInWithGithub(redirectUrl?: string) {
        let githubProvider = new GithubAuthProvider();
        return signInWithPopup(this.authService.getAuth(), githubProvider).then(
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
        return signInWithPopup(this.authService.getAuth(), googleProvider).then(
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
        fetchSignInMethodsForEmail(this.authService.getAuth(), error.customData.email)
            .then((providers => {
                availableProviders = providers.toString().replace(',', ' or ');
                switch (error.code) {
                    case 'auth/account-exists-with-different-credential': {
                        this.confirmationDialogService
                            .openConfirmationDialog(
                                ``,
                                `It seems that you would like to login with ${pendingCredential.providerId},
                                but you've already had an account in Codi.
                                To make it possible, firstly, login with ${availableProviders !== '' ? availableProviders : 'google.com'}
                                and link with ${pendingCredential.providerId} in user settings.`,
                                {
                                    cancelButton: false
                                }
                            );
                        break;
                    }
                    case 'auth/cancelled-popup-request': break;
                }
            }));
    }

    openVerificationEmail(email: string) {
        this.authService.logOut();
        this.confirmationDialogService
            .openConfirmationDialog(
                ``,
                `It seems that your email is not verified. We sent a verification letter to ${email}. To continue studying with
                        us check it out and verify it now!`,
                {
                    cancelButton: false
                }
            );
    }

    loginWithProviders(credential: UserCredential, redirectUrl?: string): void {
        this.userService.getCurrent(credential.user.uid)
            .subscribe((resp) => {
                if (resp.body) {
                    this.authService.currentUser$
                        .subscribe((user) => {
                            if (!user?.emailVerified) {
                                sendEmailVerification(user!).then(() => {
                                    this.openVerificationEmail(credential.user?.email!);
                                });
                            }
                            else {
                                this.router.navigate(['main']).then(() => {
                                    this.notificationService.showSuccessMessage('You have successfully logged in', 'Welcome back!');
                                });
                                this.authService.setUser(resp.body!);
                            }
                        });
                }
                else {
                    this.registrationService.signUpWithProviders(credential);
                }
            }, (error) => {
                if (!credential.user.emailVerified) {
                    sendEmailVerification(credential.user).then(() => {
                        this.openVerificationEmail(credential.user?.email!);
                    });
                    return;
                }
                this.registrationService.signUpWithProviders(credential);
                this.router.navigate(['main']).then(() => {
                    this.notificationService.showSuccessMessage('You have successfully logged in', 'Welcome back!');
                });
            });
    }

    signIn(email: string, password: string) {
        return from(signInWithEmailAndPassword(this.authService.getAuth(), email, password).then((credential) => {
            if(!credential.user.emailVerified){
                sendEmailVerification(credential.user!).then(() => {
                    this.openVerificationEmail(credential.user?.email!);
                });
            }
            else{
                this.router.navigate(['main']).then(() => {
                    this.notificationService.showSuccessMessage('You have successfully logged in', 'Welcome back!');
                });
            }
        })
            .catch(
                (error) => {
                    switch(error.code) {
                        case 'auth/wrong-password':
                            this.notificationService.showErrorMessage('The email address or password is incorrect', 'Error');
                            break;
                        default:
                            this.notificationService.showErrorMessage(error.code, 'Error');
                            break;
                    }
                }
            ))
    }
}
