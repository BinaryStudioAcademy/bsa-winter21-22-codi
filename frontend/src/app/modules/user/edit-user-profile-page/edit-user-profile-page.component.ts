import { Component, OnInit } from '@angular/core';
import { AuthService } from "@core/services/auth.service";
import { UserService } from "@core/services/user.service";
import { FormControl, FormGroup, Validators } from "@angular/forms";
import { Router } from "@angular/router";
import { BaseComponent } from "@core/base/base.component";
import { takeUntil } from "rxjs";
import { User } from "@core/models/user/user";
import { NotificationService } from "@core/services/notification.service";
import { regexs } from "@shared/constants/regexs";
import { Provider } from "@shared/constants/provider";
import { CredentialsService } from "@core/services/credentials.service";
import { AccessToken } from "@core/models/credentials/access-token";
import { userCredentialsAsyncValidator } from "@core/validators/user-credentials.async-validator";

@Component({
    selector: 'app-edit-user-profile-page',
    templateUrl: './edit-user-profile-page.component.html',
    styleUrls: ['./edit-user-profile-page.component.sass']
})
export class EditUserProfilePageComponent extends BaseComponent implements OnInit {
    user: User;
    form: FormGroup;
    tokenForm: FormGroup;
    imageFile: File;
    provider = Provider;
    isGoogleLinked: boolean;
    isGitHubLinked: boolean;
    isLastProviderLinked: boolean;

    constructor(
        private authService: AuthService,
        private userService: UserService,
        private credentialsService: CredentialsService,
        private notificationService: NotificationService,
        private router: Router
    ) {
        super();
    }

    ngOnInit(): void {
        this.form = new FormGroup({
            userName: new FormControl('',
                [
                    Validators.required,
                    Validators.minLength(2),
                    Validators.maxLength(25),
                    Validators.pattern(regexs.username)
                ]),
            firstName: new FormControl('',
                [
                    Validators.maxLength(60),
                    Validators.pattern(regexs.name)
                ]),
            lastName: new FormControl('',
                [
                    Validators.maxLength(60),
                    Validators.pattern(regexs.name)
                ]),
            bio: new FormControl('',
                [
                    Validators.maxLength(140),
                    Validators.pattern(regexs.title)
                ])
        });

        this.authService
            .getCurrentUser()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(user => {
                this.user = user;
                this.form.patchValue(user);
            });

        this.tokenForm = new FormGroup({
            token: new FormControl('', [
                Validators.required
            ])
        }, {
            asyncValidators: userCredentialsAsyncValidator(this.credentialsService)
        });

        this.credentialsService
            .getUserAccessToken()
            .subscribe((token) => {
                this.tokenForm.controls['token'].setValue(token.token);
            });

        this.reloadLinkedProviders();
    }

    updateUser() {
        let formValue = this.form.value;
        let updatedUser =
      {
          id : this.user.id,
          userName: formValue.userName,
          firstName : formValue.firstName,
          lastName : formValue.lastName,
          bio: formValue.bio,
          email: this.user.email
      } as User;
        this.userService
            .update(updatedUser)
            .subscribe((user) => {
                this.authService.setUser(user);
                this.router.navigate(['user', this.user.id]).then(() => {
                    this.notificationService.showSuccessMessage('User info was updated', 'Success');
                });
            });
    }

    saveCredentials() {
        this.credentialsService
            .setUpUserToken(this.tokenForm.value as AccessToken)
            .subscribe({
                next:() =>
                    this.notificationService.showSuccessMessage('Your token was saved!', 'Success'),
                error:(err) =>
                    this.notificationService.showErrorMessage(err.error, err.name)
            });
    }

    handleFileInput(target: any) {
        this.imageFile = target.files[0];

        if (!this.imageFile) {
            target.value = '';
            return;
        }

        if (this.imageFile.size / 1000000 > 5) {
            this.notificationService.showErrorMessage(`Image can't be heavier than ~5MB`);
            target.value = '';
            return;
        }

        const reader = new FileReader();
        reader.addEventListener('load', () => (this.user.avatar = reader.result as string));
        reader.readAsDataURL(this.imageFile);
    }

    linkProvider(provider: Provider) {
        this.authService
            .linkProvider(provider)
            .subscribe(() => {
                this.reloadLinkedProviders();
            });
    }

    unlinkProvider(provider: Provider) {
        this.authService
            .unlinkProvider(provider)
            .subscribe(() => {
                this.reloadLinkedProviders();
            });
    }

    reloadLinkedProviders() {
        this.authService.getLinkedProviders().subscribe((providers => {
            this.isGitHubLinked = false;
            this.isGoogleLinked = false;
            this.isLastProviderLinked = providers?.length === 1;
            providers?.forEach(item => {
                switch (item) {
                    case this.provider.google:
                        this.isGoogleLinked = true;
                        break;
                    case this.provider.github:
                        this.isGitHubLinked = true;
                        break;
                }
            })
        }))
    }
}
