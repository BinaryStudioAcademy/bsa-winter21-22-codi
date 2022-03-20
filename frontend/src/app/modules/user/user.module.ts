import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';

import { UserRoutingModule } from './user-routing.module';
import { UserProfilePageComponent } from "./user-profile-page/user-profile-page.component";
import { EditUserProfilePageComponent } from "./edit-user-profile-page/edit-user-profile-page.component";

import { FormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';


@NgModule({
    declarations: [
        UserProfilePageComponent,
        EditUserProfilePageComponent,
    ],
    imports: [
        SharedModule,
        UserRoutingModule,
        NgbModule,
        FormsModule,
    ]
})
export class UserModule { }
