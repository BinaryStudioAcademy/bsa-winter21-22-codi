import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { SharedModule } from '@shared/shared.module';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {AngularFireModule} from "@angular/fire/compat";
import {environment} from "@env/environment";
import {AngularFireAuthModule} from "@angular/fire/compat/auth";
import {CoreModule} from "@core/core.module";


@NgModule({
    declarations: [
        AppComponent
    ],
    imports: [
        BrowserModule,
        SharedModule,
        AppRoutingModule,
        NgbModule,
        BrowserAnimationsModule,
        AngularFireModule.initializeApp(environment.firebaseConfig),
        AngularFireAuthModule,
        CoreModule,
        ToastrModule.forRoot({
            timeOut: 4000,
            tapToDismiss: false,
            positionClass: 'toast-bottom-right',
        }),


    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }
