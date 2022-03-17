import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from '@shared/components/not-found/not-found.component';
import { CoursesPageComponent } from './courses-page/courses-page.component';
import { HomePageComponent } from './home-page/home-page.component';
import { MainComponent } from './main-page/main-page.component';
import { UserProfilePageComponent } from "@modules/main/user-profile-page/user-profile-page.component";
import { EditUserProfilePageComponent } from "@modules/main/edit-user-profile-page/edit-user-profile-page.component";
import { ApplicationsPageComponent } from './applications-page/applicaions-page.component';
import { TagApplicationsPageComponent } from './tag-applications-page/tag-applications-page.component';
import { TagsPageComponent } from './tags-page/tags-page.component';
import { MyProjectsPageComponent } from './my-projects-page/my-projects-page.component';
import { WorkspacePageComponent } from './workspace-page/workspace-page.component';

const routes: Routes = [{
    path: '',
    component: MainComponent,
    children: [{
        path: '',
        redirectTo: 'home',
        pathMatch: 'full',
    }, {
        path: 'apps',
        component: ApplicationsPageComponent,
    }, {
        path: 'courses',
        component: CoursesPageComponent,
    }, {
        path: 'projects',
        component: MyProjectsPageComponent,
    },{
        path: 'myprojects/workspace',
        component: WorkspacePageComponent,
    }, {
        path: 'home',
        component: HomePageComponent,
    }, {
        path: 'tags',
        component: TagsPageComponent
    }, {
        path: 'apps/tag/:id',
        component: TagApplicationsPageComponent,
        pathMatch: 'full'
    }, {
        path: 'user/:id',
        component: UserProfilePageComponent,
        pathMatch: 'full'
    }, {
        path: 'account',
        component: EditUserProfilePageComponent,
        pathMatch: 'full'
    }, {
        path: '**',
        component: NotFoundComponent,
        pathMatch: 'full'
    }],
}];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class MainRoutingModule { }
