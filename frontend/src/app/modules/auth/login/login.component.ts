import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { SignInService } from "@core/services/sign-in.service";

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.sass'],
})
export class LoginComponent implements OnInit {
    form!: FormGroup

    constructor(
        private signInService: SignInService,
    ) {}

    ngOnInit(): void {
        this.form = new FormGroup({
            login: new FormControl('', Validators.required),
            password: new FormControl('', Validators.required),
        });
    }

    withGoogle() {
        this.signInService.signInWithGoogle();
    }

    withGit() {
        this.signInService.signInWithGithub();
    }

    submit() {
        const { login, password } = this.form.value;
        this.signInService.signIn(login, password);
    }
}
