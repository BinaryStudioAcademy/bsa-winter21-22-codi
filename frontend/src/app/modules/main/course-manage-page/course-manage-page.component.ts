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
import {CourseUser} from "@core/models/course/course-user";
import {CourseRole} from "@core/models/course/course-role";
import {Unit} from "@core/models/unit/unit";
import {UnitService} from "@core/services/unit.service";
import {NewCourseDialogComponent} from "@modules/main/courses-page/new-course-dialog/new-course-dialog.component";
import {
    CreateUnitDialogComponent
} from "@modules/main/course-manage-page/create-unit-dialog/create-unit-dialog.component";
import {ConfirmationDialogResult} from "@core/models/confirmation-dialog/confirmation-dialog-result";
import {ConfirmationDialogService} from "@core/services/confirmation-dialog.service";

@Component({
    selector: 'app-course-manage-page',
    templateUrl: './course-manage-page.component.html',
    styleUrls: ['./course-manage-page.component.sass']
})
export class CourseManagePageComponent extends BaseComponent implements OnInit {
    currentCourse = {} as Course;
    currentCourseUser = {} as CourseUser;
    currentCourseName: string;
    courseUserSize: number;
    sizeMember: number = 3;
    courseRole = CourseRole;
    units: Unit[];

    constructor(
        private courseService: CourseService,
        private unitService: UnitService,
        private route: ActivatedRoute,
        private router: Router,
        private authService: AuthService,
        private modalService: NgbModal,
        private notificationService: NotificationService,
        private confirmationDialogService: ConfirmationDialogService
    )
    {
        super();
    }

    ngOnInit(): void {

        this.route.params
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next:() => {
                    this.currentCourseName = this.route.snapshot.params['name'];
                    this.getCourse();
                },
                error: () => {
                    this.notificationService.showErrorMessage('Something went wrong', 'Error')
                }
            });
    }

    createUnit() {
        const modalRef = this.modalService.open(CreateUnitDialogComponent, { centered: true })
        modalRef.componentInstance.course = this.currentCourse;
        modalRef.result
            .then((result) => {
                if(result) {
                    this.getCourseUnits();
                }
            }).catch(noop);
    }

    deleteUnit(unitId: number) {
        let unit = this.units.find(u => u.id === unitId);
        this.confirmationDialogService
            .openConfirmationDialog(
                `Delete ${unit?.title}?`,
                `Deleting will remove the Unit from this Course,
                and all Projects in this Unit will be deleted.
                Are you sure you want to delete this Unit?
                Be careful, deleting a unit cannot be undone.`,
                {
                    centered: true,
                    confirmButtonClass: "btn btn-danger",
                    cancelButtonClass: "btn btn-primary",
                    confirmButtonText: "Delete"
                }
            )
            .subscribe((result) => {
                if(result === ConfirmationDialogResult.Confirm) {
                    this.unitService
                        .delete(unitId)
                        .pipe(takeUntil(this.unsubscribe$))
                        .subscribe({
                            next:() => {
                                this.getCourseUnits();
                                this.notificationService.showSuccessMessage("Unit deleted", 'Success');
                            },
                            error:() => this.notificationService.showErrorMessage("Something went wrong...", 'Error')
                        });
                }
            });
    }

    getCourse() {
        this.courseService.getCourse(this.currentCourseName)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next:(resp) => {
                    this.currentCourse = resp;
                    this.courseUserSize = resp.courseUsers.length;
                    this.getCurrentCourseUser(resp.id);
                    this.getCourseUnits();
                },
                error: () =>
                    this.notificationService.showErrorMessage('Something went wrong', 'Error')
            });
    }

    getCourseUnits() {
        this.unitService.getCourseUnits(this.currentCourse.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next:(units) => {
                    this.units = units;
                },
                error: () =>
                    this.notificationService.showErrorMessage('Something went wrong', 'Error')
            });
    }

    getCurrentCourseUser(courseId: number) {
        this.courseService
            .getCourseUser(courseId)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(cu => this.currentCourseUser = cu);
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
