import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { SharedModule } from '@shared/shared.module';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {environment} from "@env/environment";
import {CoreModule} from "@core/core.module";
import {initializeApp, provideFirebaseApp} from "@angular/fire/app";
import {getAuth, provideAuth} from "@angular/fire/auth";


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
        provideFirebaseApp(() => initializeApp(environment.firebaseConfig)),
        provideAuth(() => getAuth()),
        CoreModule,
        ToastrModule.forRoot({
            timeOut: 6000,
            tapToDismiss: true,
            positionClass: 'toast-bottom-right',
        }),
    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }
