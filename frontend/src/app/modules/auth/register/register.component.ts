import { Component, OnInit } from '@angular/core';
import {FormControl, FormGroup, Validators} from "@angular/forms";
import {regexs} from "@shared/constants/regexs";

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.sass']
})
export class RegisterComponent implements OnInit {
  form!: FormGroup

  constructor() { }

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
          Validators.pattern(regexs.email),
          Validators.maxLength(128)
        ]),
      password: new FormControl('',
        [
          Validators.minLength(8),
          Validators.maxLength(35),
          Validators.pattern(regexs.password)
        ])
    })
  }
}
