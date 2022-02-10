import {Component, OnInit} from '@angular/core';
import {FormControl, FormGroup, Validators} from "@angular/forms";
import {CustomValidators} from "@modules/auth/shared/custom-validators";
import {AuthService} from "@core/services/auth.service";
import {CurrentUser} from "@core/models/current-user";
import {Subscription} from "rxjs";


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.sass']
})
export class RegisterComponent implements OnInit {
  form!: FormGroup
  currentUser: CurrentUser = new CurrentUser();
  $authSubscription: Subscription;

  constructor(private authService: AuthService)
  {
    this.$authSubscription = this.authService.user$.subscribe(u => {
      this.currentUser = u;
    });
  }

  ngOnInit(): void {
    this.form = new FormGroup({
      username: new FormControl('',
        [
          Validators.required,
          Validators.minLength(2),
          Validators.maxLength(15),
          CustomValidators.patternValidator(/\d/, { hasNumber: true }),
          CustomValidators.patternValidator(/[a-zA-Z]/, { hasLetter: true })
          ]),
      email: new FormControl('',
        [Validators.required, Validators.email]),
      password: new FormControl('',
        [
          Validators.minLength(8),
          Validators.maxLength(35),
          CustomValidators.patternValidator(/[A-Z]/, { hasCapitalCase: true }),
          CustomValidators.patternValidator(/[a-z]/, { hasSmallCase: true }),
          CustomValidators.patternValidator(/\d/, { hasNumber: true }),
          CustomValidators.patternValidator(/(?=.*[-_!@#$%^&*.])/, { hasSpecialCharacters: true })
        ])
    })
  }

  WithGoogle() {
    this.authService.googleSignIn().then()

  }
}
