import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { NotFoundComponent } from '@shared/components/not-found/not-found.component';
import { ApplicationsComponent } from './applications/applicaions.component';
import { MainComponent } from './main-page/main-page.component';

const routes: Routes = [{
    path: '',
    component: MainComponent,
    children: [{
        path: '',
        redirectTo: 'applications',
        pathMatch: 'full',
    }, {
        path: 'applications',
        component: ApplicationsComponent,
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