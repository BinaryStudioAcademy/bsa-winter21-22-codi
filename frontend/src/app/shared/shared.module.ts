import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

import { LoadingSpinnerComponent } from './components/loading-spinner/loading-spinner.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { ConfirmationDialogComponent } from './components/confirmation-dialog/confirmation-dialog.component';
import {CreateReplModalComponent} from "@shared/components/create-repl-modal/create-repl-modal.component";
import {NgbTypeaheadModule} from "@ng-bootstrap/ng-bootstrap";
import {
    ImportGithubProjectModalComponent
} from "@shared/components/import-github-project-modal/import-github-project-modal.component";

@NgModule({
    imports: [
        CommonModule,
        RouterModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule,
        NgbTypeaheadModule
    ],
    declarations: [
        LoadingSpinnerComponent,
        NotFoundComponent,
        ConfirmationDialogComponent,
        CreateReplModalComponent,
        ImportGithubProjectModalComponent
    ],
    exports: [
        CommonModule,
        RouterModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule,
        LoadingSpinnerComponent,
        NotFoundComponent,
    ],
})
export class SharedModule { }
