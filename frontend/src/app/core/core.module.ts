import { NgModule } from '@angular/core';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { SharedModule } from '../shared/shared.module';

import { ErrorInterceptor } from './interceptors/error.interceptor';
import { BaseComponent } from './base/base.component';
import { JwtInterceptor } from '@core/interceptors/jwt.interceptor';
import { DateAgoPipe } from './pipes/date-ago.pipe';

@NgModule({
    imports: [
        HttpClientModule,
        SharedModule,
    ],
    providers: [
        {provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true},
        {provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true},
    ],
    declarations: [
        BaseComponent,
        DateAgoPipe,
    ],
    exports: [
        DateAgoPipe
    ]
})
export class CoreModule { }
