import { Component, OnInit } from '@angular/core';
import {FormControl, FormGroup, Validators} from "@angular/forms";
import { NotificationService } from '@core/services/notification.service';
import {AuthService} from "@core/services/auth.service";
import {Router} from "@angular/router";


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.sass']
})
export class LoginComponent implements OnInit {

  form!: FormGroup

  constructor(
    private notificationService: NotificationService,
    private authService: AuthService,
    private router: Router
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
    this.authService.withGoogle()
      .subscribe( () => {
        this.router.navigate(['main'])
      });
  }

  withGit() {
    this.authService.withGitHub()
      .subscribe( () => {
        this.router.navigate(['main'])
      });
  }

  submit() {
    const {login, password} = this.form.value;
    this.authService.signIn(login, password)
      .subscribe( () => {
        this.router.navigate(['main'])
      });
  }
}
