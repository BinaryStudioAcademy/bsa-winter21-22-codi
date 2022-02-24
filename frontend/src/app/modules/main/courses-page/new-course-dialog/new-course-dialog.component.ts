import { Component, Input, OnInit } from '@angular/core';
import { NgbActiveModal } from "@ng-bootstrap/ng-bootstrap";
import { NotificationService } from "@core/services/notification.service";
import { CourseService } from "@core/services/course.service";
import { FormControl, FormGroup, Validators } from "@angular/forms";
import { BaseComponent } from "@core/base/base.component";
import { takeUntil } from "rxjs";
import { CreateCourse } from "@core/models/course/create-course";
import { Course } from "@core/models/course/course";
import { Organization } from "@core/models/organization/organization";

@Component({
    selector: 'app-new-course-dialog',
    templateUrl: './new-course-dialog.component.html',
    styleUrls: ['./new-course-dialog.component.sass']
})
export class NewCourseDialogComponent extends BaseComponent implements OnInit {
    @Input() org: Organization;
    form: FormGroup;

    constructor(
        public modal: NgbActiveModal,
        private notificationsService: NotificationService,
        private courseService: CourseService
    ) {
        super();
    }

    ngOnInit(): void {
        this.form = new FormGroup({
            displayName: new FormControl('',
                [
                    Validators.required,
                    Validators.minLength(5),
                    Validators.maxLength(100)
                ]),
            name: new FormControl('',
                [
                    Validators.required,
                    Validators.minLength(5),
                    Validators.maxLength(100)
                ]),
        });
    }

    createCourse() {
        let createdCourse: Course | null = null;
        let formValue = this.form.value;
        let createCourse =
            {
                displayName: formValue.displayName,
                name: formValue.name,
                organizationId: this.org.id
            } as CreateCourse;
        this.courseService
            .create(createCourse)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                (org) => {
                    createdCourse = org.body;
                    this.notificationsService.showSuccessMessage('Course successfully created');
                },
                (error) => this.notificationsService.showErrorMessage('This username have already used'),
                () => this.modal.close(createdCourse)
            );
    }

    closeDialog() {
        this.modal.close();
    }
}
