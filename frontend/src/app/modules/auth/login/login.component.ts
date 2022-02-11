import { Component, OnInit } from '@angular/core';
import {FormControl, FormGroup, Validators} from "@angular/forms";
import { NotificationService } from '@core/services/notification.service';
import {AuthService} from "@core/services/auth.service";


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.sass']
})
export class LoginComponent implements OnInit {

  form!: FormGroup

  constructor(
    private notificationService: NotificationService,
    private authService: AuthService
  ) {}

  ngOnInit(): void {
    this.form = new FormGroup({
      login: new FormControl('', Validators.required),
      password: new FormControl('', Validators.required)
    })
  }

  showTestSuccessMessage() {
    this.notificationService.showSuccessMessage("You have successfully logged in", "Welcome back!");
  }

  withGoogle() {
    this.authService.GoogleAuth();
  }

  submit() {
    let userDate = this.form.value;
    this.authService.SignIn(userDate.login, userDate.password)

  }
}
