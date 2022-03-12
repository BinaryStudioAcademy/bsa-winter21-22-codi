import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { regexs } from '@shared/constants/regexs';
import { SignInService } from "@core/services/sign-in.service";
import { RegistrationService } from "@core/services/registration.service";

@Component({
    selector: 'app-register',
    templateUrl: './register.component.html',
    styleUrls: ['./register.component.sass'],
})
export class RegisterComponent implements OnInit {
    form!: FormGroup

    constructor(
        private signInService: SignInService,
        private registrationService: RegistrationService
    ) {}

    ngOnInit(): void {
        this.form = new FormGroup({
            username: new FormControl('',
                [
                    Validators.required,
                    Validators.minLength(2),
                    Validators.maxLength(25),
                    Validators.pattern(regexs.username),
                ]),
            email: new FormControl('',
                [
                    Validators.required,
                    Validators.pattern(regexs.email),
                    Validators.maxLength(128),
                ]),
            password: new FormControl('',
                [
                    Validators.required,
                    Validators.minLength(8),
                    Validators.maxLength(35),
                    Validators.pattern(regexs.password),
                ]),
        });
    }

    withGoogle() {
        this.signInService.signInWithGoogle();
    }

    withGit() {
        this.signInService.signInWithGithub();
    }

    submit() {
        if (!this.form.valid) return;
        const { username, email, password } = this.form.value;
        this.registrationService.signUp(username, email, password);
    }
}
