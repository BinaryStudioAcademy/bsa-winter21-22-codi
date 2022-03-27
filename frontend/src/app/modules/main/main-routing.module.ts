import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from '@shared/components/not-found/not-found.component';
import { CoursesPageComponent } from './courses-page/courses-page.component';
import { HomePageComponent } from './home-page/home-page.component';
import { MainComponent } from './main-page/main-page.component';
import { ApplicationsPageComponent } from './applications-page/applicaions-page.component';
import { TagApplicationsPageComponent } from './tag-applications-page/tag-applications-page.component';
import { TagsPageComponent } from './tags-page/tags-page.component';
import { MyProjectsPageComponent } from './my-projects-page/my-projects-page.component';
import { CourseManagePageComponent } from './course-manage-page/course-manage-page.component';

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
    },{
        path: 'courses/:name',
        component: CourseManagePageComponent,
    },{
        path: 'projects',
        component: MyProjectsPageComponent,
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
