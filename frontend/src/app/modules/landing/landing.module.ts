import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';

import { LandingPageComponent } from './landing-page/landing-page.component';
import { LandingRoutingModule } from './landing-routing.module';
import { LandingHeaderComponent } from './landing-header/landing-header.component';
import { LandingFooterComponent } from './landing-footer/landing-footer.component';
import { LandingContentComponent } from './landing-content/landing-content.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
    declarations: [
        LandingPageComponent,
        LandingHeaderComponent,
        LandingFooterComponent,
        LandingContentComponent,
    ],
    imports: [
        SharedModule, LandingRoutingModule, NgbModule,
    ],
})
export class LandingModule { }
