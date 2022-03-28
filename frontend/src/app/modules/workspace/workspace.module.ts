import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';

import { WorkspaceRoutingModule } from './workspace-routing.module';
import { WorkspacePageComponent } from './workspace-page/workspace-page.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { MonacoEditorModule } from 'ngx-monaco-editor';
import { FormsModule } from '@angular/forms';
import { TreeModule } from "@circlon/angular-tree-component";

@NgModule({
    declarations: [
        WorkspacePageComponent
    ],
    imports: [
        SharedModule,
        WorkspaceRoutingModule,
        NgbModule,
        FormsModule,
        MonacoEditorModule,
        TreeModule
    ]
})
export class WorkspaceModule { }
