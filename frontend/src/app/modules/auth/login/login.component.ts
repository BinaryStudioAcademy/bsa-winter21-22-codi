import { Component, OnInit } from '@angular/core';
import {FormControl, FormGroup, Validators} from "@angular/forms";
import { NotificationService } from '@core/services/notification.service';
import {AuthService} from "@core/services/auth.service";
import {Subscription} from "rxjs";
import {CurrentUser} from "@core/models/current-user";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.sass']
})
export class LoginComponent implements OnInit {
  form!: FormGroup
  currentUser: CurrentUser = new CurrentUser();
  $authSubscription: Subscription;

  constructor(
    private notificationService: NotificationService,
    private authService: AuthService
  )
  {
    this.$authSubscription = this.authService.user$.subscribe(u => {
      this.currentUser = u;
    });
  }

  ngOnInit(): void {
    this.form = new FormGroup({
      login: new FormControl('', Validators.required),
      password: new FormControl('', Validators.required)
    })
  }

  showTestSuccessMessage() {
    this.notificationService.showSuccessMessage("You have successfully logged in", "Welcome back!");
  }

  WithGoogle() {
    this.authService.googleSignIn().then()
  }
}
