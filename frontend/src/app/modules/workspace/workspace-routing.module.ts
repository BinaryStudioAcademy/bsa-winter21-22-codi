import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { WorkspacePageComponent } from './workspace-page/workspace-page.component';

const routes: Routes = [
    { path: '',
        component: WorkspacePageComponent 
    }];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class WorkspaceRoutingModule { }
