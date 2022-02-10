import { Component, OnInit } from '@angular/core';
import {FormControl, FormGroup, Validators} from "@angular/forms";

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
          Validators.pattern(/^[A-Za-z0-9]+$/)
        ]),
      email: new FormControl('',
        [
          Validators.required,
          Validators.pattern(/^[a-zA-Z0-9]{1}[-a-zA-Z0-9._]{1,33}[a-zA-Z0-9]{1}@[a-zA-Z0-9]{1,17}[.][a-zA-Z]{1,17}$/)
        ]),
      password: new FormControl('',
        [
          Validators.minLength(8),
          Validators.maxLength(35),
          Validators.pattern(/^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!"#$%&'()*+,\-./:;<=>?@[\]^_`{|}~])[A-Za-z\d!"#$%&'()*+,\-./:;<=>?@[\]^_`{|}~]{8,35}$/)
        ])
    })
  }
}
