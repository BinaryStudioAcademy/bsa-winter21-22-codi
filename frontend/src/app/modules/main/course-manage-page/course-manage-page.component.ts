import { Component, OnInit } from '@angular/core';
import {CourseService} from "@core/services/course.service";
import {Course} from "@core/models/course/course";
import {takeUntil} from "rxjs";
import {BaseComponent} from "@core/base/base.component";
import {ActivatedRoute, Router} from "@angular/router";
import {AuthService} from "@core/services/auth.service";
import {NgbModal} from "@ng-bootstrap/ng-bootstrap";
import {CourseInviteDialogComponent} from "@modules/main/course-manage-page/course-invite-dialog/course-invite-dialog.component";
import {NotificationService} from "@core/services/notification.service";
import {UpdateCourseDialogComponent} from "@modules/main/course-manage-page/update-course-dialog/update-course-dialog.component";
import {noop} from "@shared/common/utils";

@Component({
    selector: 'app-course-manage-page',
    templateUrl: './course-manage-page.component.html',
    styleUrls: ['./course-manage-page.component.sass']
})
export class CourseManagePageComponent extends BaseComponent implements OnInit {
    currentCourse = {} as Course;
    currentCourseName: string;
    courseUserSize: number;
    sizeMember: number = 3;

    constructor(
        private coursesService: CourseService,
        private route: ActivatedRoute,
        private router: Router,
        private authService: AuthService,
        private modalService: NgbModal,
        private notificationService: NotificationService
    )
    {
        super();
    }

    ngOnInit(): void {
        this.route.params
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(() => {
                this.currentCourseName = this.route.snapshot.params['name'];
                this.getCourse();
            })
    }

    getCourse() {
        this.coursesService.getCourse(this.currentCourseName)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next:(resp) => {
                    this.currentCourse = resp;
                    this.courseUserSize = resp.courseUsers.length;
                },
                error: () =>
                    this.notificationService.showErrorMessage('Something went wrong', 'Error')

            });
    }

    inviteMembers(currentCourse: Course) {
        const modalRef = this.modalService.open(CourseInviteDialogComponent, {centered: true});
        modalRef.componentInstance.course = currentCourse;
        modalRef.dismissed.pipe(takeUntil(this.unsubscribe$)).subscribe(() => {
            this.getCourse();
        });
        modalRef.result.then(() => this.getCourse()).catch(noop);
    }

    editCourse(currentCourse: Course) {
        const modalRef = this.modalService.open(UpdateCourseDialogComponent, {centered: true});
        modalRef.componentInstance.course = currentCourse;
        modalRef.result.then((result) => {
            if(result) {
                this.getCourse();
            }
        }).catch(noop);
    }
}
