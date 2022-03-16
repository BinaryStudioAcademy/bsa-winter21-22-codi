import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';

import { ApplicationsPageComponent } from './applications-page/applicaions-page.component';
import { MainComponent } from './main-page/main-page.component';
import { MainRoutingModule } from './main-routing.module';
import { HomePageComponent } from './home-page/home-page.component';
import { HeaderComponent } from './header/header.component';
import { TopNavComponent } from './header/top-nav/top-nav.component';
import { SideNavTogglerComponent } from './header/side-nav-toggler/side-nav-toggler.component';
import { SideNavComponent } from './header/side-nav/side-nav.component';
import { CoursesPageComponent } from './courses-page/courses-page.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { MonacoEditorModule } from 'ngx-monaco-editor';
import { FormsModule } from '@angular/forms';
import { PublishAppDialogComponent } from './applications-page/publish-app-dialog/publish-app-dialog.component';
import { UserProfilePageComponent } from "@modules/main/user-profile-page/user-profile-page.component";
import { EditUserProfilePageComponent } from "@modules/main/edit-user-profile-page/edit-user-profile-page.component";
import { NewOrganizationDialogComponent } from './courses-page/new-organization-dialog/new-organization-dialog.component';
import { NewCourseDialogComponent } from './courses-page/new-course-dialog/new-course-dialog.component';
import {
    UpdateOrganizationDialogComponent
} from "@modules/main/courses-page/update-organization-dialog/update-organization-dialog.component";
import { AppCardComponent } from './applications-page/app-card/app-card.component';
import { TagApplicationsPageComponent } from './tag-applications-page/tag-applications-page.component';
import { TagsPageComponent } from './tags-page/tags-page.component';
import { MyProjectsPageComponent } from './my-projects-page/my-projects-page.component';

@NgModule({
    declarations: [
        MainComponent,
        ApplicationsPageComponent,
        HomePageComponent,
        HeaderComponent,
        TopNavComponent,
        SideNavTogglerComponent,
        SideNavComponent,
        MyProjectsPageComponent,
        CoursesPageComponent,
        PublishAppDialogComponent,
        UserProfilePageComponent,
        EditUserProfilePageComponent,
        NewOrganizationDialogComponent,
        NewCourseDialogComponent,
        UpdateOrganizationDialogComponent,
        AppCardComponent,
        TagApplicationsPageComponent,
        TagsPageComponent,
    ],
    imports: [
        SharedModule,
        MainRoutingModule,
        NgbModule,
        FormsModule,
        MonacoEditorModule,
    ],
})
export class MainModule { }
