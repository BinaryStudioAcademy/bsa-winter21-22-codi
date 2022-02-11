import {Component, OnInit} from '@angular/core';
import {FormControl, FormGroup, Validators} from "@angular/forms";
import {regexs} from "@shared/constants/regexs";
import {AuthService} from "@core/services/auth.service";
import {Router} from "@angular/router";


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.sass']
})
export class RegisterComponent implements OnInit {

  form!: FormGroup

  constructor(private authService: AuthService, private router: Router) {}

  ngOnInit(): void {
    this.form = new FormGroup({
      username: new FormControl('',
        [
          Validators.required,
          Validators.minLength(2),
          Validators.maxLength(15),
          Validators.pattern(regexs.username)
        ]),
      email: new FormControl('',
        [
          Validators.required,
          Validators.pattern(regexs.email)
        ]),
      password: new FormControl('',
        [
          Validators.minLength(8),
          Validators.maxLength(35),
          Validators.pattern(regexs.password)
        ])
    })
  }

  withGoogle() {
    this.authService.GoogleAuth();

  }

  submit() {
    let userReg = this.form.value;
    this.authService.SignUp(userReg.username,userReg.email,userReg.password)
      .then(() => {
        this.router.navigate(['login'])
      })
  }
}
