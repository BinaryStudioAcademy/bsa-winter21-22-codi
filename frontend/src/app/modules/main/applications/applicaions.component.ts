import { Component } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { PublishAppDialogComponent } from './publish-app-dialog/publish-app-dialog.component';

@Component({
    selector: 'app-applications',
    templateUrl: './applicaions.component.html',
    styleUrls: ['./applicaions.component.sass'],
})
export class ApplicationsComponent {
    constructor(private modalService: NgbModal) {}

    publichApp() {
        this.modalService.open(PublishAppDialogComponent, { centered: true });
    }
}
