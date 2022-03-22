import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

import { LoadingSpinnerComponent } from './components/loading-spinner/loading-spinner.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { ConfirmationDialogComponent } from './components/confirmation-dialog/confirmation-dialog.component';
import { CreateProjectDialogComponent } from "@shared/components/create-project-dialog/create-project-dialog.component";
import { NgbDropdownModule, NgbTypeaheadModule } from "@ng-bootstrap/ng-bootstrap";
import { HeaderComponent } from './components/header/header.component';
import { TopNavComponent } from './components/header/top-nav/top-nav.component';
import { SideNavTogglerComponent } from './components/header/side-nav-toggler/side-nav-toggler.component';
import { SideNavComponent } from './components/header/side-nav/side-nav.component';
import { NotFoundHeaderComponent } from './components/not-found/not-found-header/not-found-header.component';
import {
    ImportGithubProjectDialogComponent
} from "@shared/components/import-github-project-dialog/import-github-project-dialog.component";

@NgModule({
    imports: [
        CommonModule,
        RouterModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule,
        NgbTypeaheadModule,
        NgbDropdownModule
    ],
    declarations: [
        LoadingSpinnerComponent,
        NotFoundComponent,
        ConfirmationDialogComponent,
        CreateProjectDialogComponent,
        HeaderComponent,
        TopNavComponent,
        SideNavTogglerComponent,
        SideNavComponent,
        NotFoundHeaderComponent,
        ImportGithubProjectDialogComponent
    ],
    exports: [
        CommonModule,
        RouterModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule,
        LoadingSpinnerComponent,
        NotFoundComponent,
        HeaderComponent,
        TopNavComponent,
        SideNavTogglerComponent,
        SideNavComponent,
    ],
})
export class SharedModule { }
