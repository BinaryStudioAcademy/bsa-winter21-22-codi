import { Component } from '@angular/core';
import { NgbModal } from "@ng-bootstrap/ng-bootstrap";
import { NewCourseDialogComponent } from "@modules/main/courses-page/new-course-dialog/new-course-dialog.component";
import {
    NewOrganizationDialogComponent
} from "@modules/main/courses-page/new-organization-dialog/new-organization-dialog.component";

@Component({
    selector: 'app-courses-page',
    templateUrl: './courses-page.component.html',
    styleUrls: ['./courses-page.component.sass'],
})
export class CoursesPageComponent {
    constructor(private modalService: NgbModal) { }

    createCourse() {
        this.modalService.open(NewCourseDialogComponent, { centered: true });
    }

    createOrganization() {
        this.modalService.open(NewOrganizationDialogComponent, { centered: true });
    }
}
