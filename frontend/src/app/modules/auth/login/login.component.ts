import { Component, OnInit } from '@angular/core';
import {FormControl, FormGroup, Validators} from "@angular/forms";
import {AuthService} from "@core/services/auth.service";


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.sass']
})
export class LoginComponent implements OnInit {

  form!: FormGroup

  constructor(
    private authService: AuthService,
  ) {}

  ngOnInit(): void {
    this.form = new FormGroup({
      login: new FormControl('', Validators.required),
      password: new FormControl('', Validators.required)
    })
  }

  withGoogle() {
    this.authService.withGoogle();
  }

  withGit() {
    this.authService.withGitHub();
  }

  submit() {
    const {login, password} = this.form.value;
    this.authService.signIn(login, password);
  }
}
