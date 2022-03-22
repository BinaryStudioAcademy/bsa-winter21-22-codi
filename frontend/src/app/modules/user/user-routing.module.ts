import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserProfilePageComponent } from "./user-profile-page/user-profile-page.component";
import { EditUserProfilePageComponent } from "./edit-user-profile-page/edit-user-profile-page.component";
import { NotFoundComponent } from '@shared/components/not-found/not-found.component';

const routes: Routes = [{
    path: 'user/:id',
    component: UserProfilePageComponent,
    pathMatch: 'full',
}, {
    path: 'account',
    component: EditUserProfilePageComponent,
    pathMatch: 'full',
}, {
    path: '**',
    component: NotFoundComponent,
    pathMatch: 'full'
}];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class UserRoutingModule { }
