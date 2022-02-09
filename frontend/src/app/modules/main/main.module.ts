import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';

import { ApplicationsComponent } from './applications/applicaions.component';
import { MainComponent } from './main-page/main-page.component';
import { MainRoutingModule } from './main-routing.module';
import { HomePageComponent } from './home-page/home-page.component';
import { HeaderComponent } from './header/header.component';
import { TopNavComponent } from './header/top-nav/top-nav.component';
import { SideNavTogglerComponent } from './header/side-nav-toggler/side-nav-toggler.component';
import { SideNavComponent } from './header/side-nav/side-nav.component';
import { MyprojectsPageComponent } from './myprojects-page/myprojects-page.component';
import { CoursesPageComponent } from './courses-page/courses-page.component';
import { CreateButtonComponent } from './create-button/create-button.component';
import { SideNavCreateButtonComponent } from './create-button/side-nav-create-button/side-nav-create-button.component';

@NgModule({
    declarations: [
        MainComponent,
        ApplicationsComponent,
        HomePageComponent,
        HeaderComponent,
        TopNavComponent,
        SideNavTogglerComponent,
        SideNavComponent,
        MyprojectsPageComponent,
        CoursesPageComponent,
        CreateButtonComponent,
        SideNavCreateButtonComponent,
    ],
    imports: [
        SharedModule,
        MainRoutingModule
    ],
})
export class MainModule { }