import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { NotFoundComponent } from '@shared/components/not-found/not-found.component';
import { ApplicationsComponent } from './applications/applicaions.component';
import { MyProjectsPageComponent } from './myprojects-page/myprojects-page.component';
import { CoursesPageComponent } from './courses-page/courses-page.component';
import { HomePageComponent } from './home-page/home-page.component';
import { MainComponent } from './main-page/main-page.component';
import { UserProfilePageComponent } from "@modules/main/user-profile-page/user-profile-page.component";
import { EditUserProfilePageComponent } from "@modules/main/edit-user-profile-page/edit-user-profile-page.component";

const routes: Routes = [{
    path: '',
    component: MainComponent,
    children: [{
        path: '',
        redirectTo: 'home',
        pathMatch: 'full',
    }, {
        path: 'applications',
        component: ApplicationsComponent,
    }, {
        path: 'courses',
        component: CoursesPageComponent,
    },{
        path: 'myprojects',
        component: MyProjectsPageComponent,
    },{
        path: 'home',
        component: HomePageComponent,
    }, {
        path: 'profile',
        component: UserProfilePageComponent,
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
    }]
}];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class MainRoutingModule { }
