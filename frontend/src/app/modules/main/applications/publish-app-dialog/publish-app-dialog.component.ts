import { Component } from '@angular/core';
import { NotificationService } from '@core/services/notification.service';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
    templateUrl: './publish-app-dialog.component.html',
    styleUrls: ['./publish-app-dialog.component.sass'],
})
export class PublishAppDialogComponent {
    constructor(public modal: NgbActiveModal, private notificationsService: NotificationService) {}

    publishProject() {
        this.notificationsService.showSuccessMessage('App successfully published');
        this.modal.close();
    }

    closeDialog() {
        this.modal.close();
    }
}
