import { Component, OnInit } from '@angular/core';
import { NotificationService } from '@core/services/notification.service';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
    templateUrl: './publish-app-dialog.component.html',
    styleUrls: ['./publish-app-dialog.component.sass']
})
export class PublishAppDialogComponent implements OnInit {

    constructor(public modal: NgbActiveModal, private notificationsService: NotificationService) {}

    ngOnInit(): void {
    }

    publishProject() {
        this.notificationsService.showSuccessMessage("App successfully published");
        this.modal.close();
    }

}
