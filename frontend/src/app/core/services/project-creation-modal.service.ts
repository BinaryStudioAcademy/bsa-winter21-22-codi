import { Injectable } from '@angular/core';
import { NgbModal } from "@ng-bootstrap/ng-bootstrap";
import { CreateProjectDialogComponent } from "@shared/components/create-project-dialog/create-project-dialog.component";

@Injectable({
    providedIn: 'root'
})
export class ProjectCreationModalService {

    constructor(private modalService: NgbModal) {}

    openCreateDialog() {
        return this.modalService.open(CreateProjectDialogComponent, {centered: true});
    }
}
