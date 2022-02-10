import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AuthRoutingModule } from './auth-routing.module';
import { LoginComponent } from './login/login.component';
import { ReactiveFormsModule } from "@angular/forms";
import { RegisterComponent } from "@modules/auth/register/register.component";
import { SecretComponent } from './secret/secret.component';


@NgModule({
    declarations: [
        LoginComponent,
        RegisterComponent,
        SecretComponent
    ],
  imports: [
    CommonModule,
    AuthRoutingModule,
    ReactiveFormsModule
  ]
})
export class AuthModule { }
