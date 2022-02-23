import { Component } from '@angular/core';
import { NgbActiveModal } from "@ng-bootstrap/ng-bootstrap";
import { NotificationService } from "@core/services/notification.service";

@Component({
  selector: 'app-new-course-dialog',
  templateUrl: './new-course-dialog.component.html',
  styleUrls: ['./new-course-dialog.component.sass']
})
export class NewCourseDialogComponent {
    constructor(public modal: NgbActiveModal, private notificationsService: NotificationService) {}

    createCourse() {
        this.notificationsService.showSuccessMessage('Course successfully created');
        this.modal.close();
    }

    closeDialog() {
        this.modal.close();
    }
}
