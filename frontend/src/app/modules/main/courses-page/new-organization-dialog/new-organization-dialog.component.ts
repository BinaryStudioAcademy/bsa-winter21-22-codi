import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from "@ng-bootstrap/ng-bootstrap";
import { NotificationService } from "@core/services/notification.service";

@Component({
  selector: 'app-new-organization-dialog',
  templateUrl: './new-organization-dialog.component.html',
  styleUrls: ['./new-organization-dialog.component.sass']
})
export class NewOrganizationDialogComponent {
    constructor(public modal: NgbActiveModal, private notificationsService: NotificationService) {}

    createOrganization() {
        this.notificationsService.showSuccessMessage('Organization successfully created');
        this.modal.close();
    }

    closeDialog() {
        this.modal.close();
    }
}
