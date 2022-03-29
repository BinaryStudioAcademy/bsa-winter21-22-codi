import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { WorkspacePageComponent } from './workspace-page/workspace-page.component';
import { NotFoundComponent } from "@shared/components/not-found/not-found.component";
import { SaveBeforeLeave } from "@core/guards/save-before-leave.guard";

const routes: Routes = [
    {
        path: ':id',
        component: WorkspacePageComponent,
        pathMatch: 'full',
        canDeactivate: [SaveBeforeLeave]
    },
    {
        path: '**',
        component: NotFoundComponent,
        pathMatch: 'full'
    }];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class WorkspaceRoutingModule { }
