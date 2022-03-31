import { Component, OnInit } from '@angular/core';
import { CourseService } from "@core/services/course.service";
import { Course } from "@core/models/course/course";
import { takeUntil } from "rxjs";
import { BaseComponent } from "@core/base/base.component";
import { ActivatedRoute, Router } from "@angular/router";
import { AuthService } from "@core/services/auth.service";
import { NgbModal } from "@ng-bootstrap/ng-bootstrap";
import { CourseInviteDialogComponent } from "@modules/main/course-manage-page/course-invite-dialog/course-invite-dialog.component";
import { NotificationService } from "@core/services/notification.service";
import { UpdateCourseDialogComponent } from "@modules/main/course-manage-page/update-course-dialog/update-course-dialog.component";
import { noop } from "@shared/common/utils";
import { CourseUser } from "@core/models/course/course-user";
import { CourseRole } from "@core/models/course/course-role";
import { Unit } from "@core/models/unit/unit";
import { UnitService } from "@core/services/unit.service";
import {
    CreateUnitDialogComponent
} from "@modules/main/course-manage-page/create-unit-dialog/create-unit-dialog.component";
import { ConfirmationDialogResult } from "@core/models/confirmation-dialog/confirmation-dialog-result";
import { ConfirmationDialogService } from "@core/services/confirmation-dialog.service";
import {
    CreateLessonDialogComponent
} from "@modules/main/course-manage-page/create-lesson-dialog/create-lesson-dialog.component";
import { Lesson } from "@core/models/lesson/lesson";
import { LessonService } from "@core/services/lesson.service";
import { PublishLesson } from "@core/models/lesson/publish-lesson";
import {
    AddToUnitDialogComponent
} from "@modules/main/course-manage-page/add-to-unit-dialog/add-to-unit-dialog.component";
import { LessonToUnit } from "@core/models/lesson/lesson-to-unit";

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
    lessons: Lesson[];

    constructor(
        private courseService: CourseService,
        private unitService: UnitService,
        private lessonService: LessonService,
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

    createLesson() {
        const modalRef = this.modalService.open(CreateLessonDialogComponent, { centered: true })
        modalRef.componentInstance.course = this.currentCourse;
        modalRef.result
            .then((result) => {
                if(result) {
                    this.reloadPageContent();
                }
            }).catch(noop);
    }

    createUnit() {
        const modalRef = this.modalService.open(CreateUnitDialogComponent, { centered: true })
        modalRef.componentInstance.course = this.currentCourse;
        modalRef.result
            .then((result) => {
                if(result) {
                    this.reloadPageContent();
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
                                this.reloadPageContent();
                                this.notificationService.showSuccessMessage("Unit deleted", 'Success');
                            },
                            error:() => this.notificationService.showErrorMessage("Something went wrong...", 'Error')
                        });
                }
            });
    }

    deleteLesson(lessonId: number) {
        let lesson = this.lessons.find(l => l.id === lessonId);
        this.confirmationDialogService
            .openConfirmationDialog(
                `Delete ${lesson?.title}?`,
                `Deleting will remove the Lesson from this Course,
                and the project in this lesson will be deleted.
                Are you sure you want to delete this Lesson?
                Be careful, deleting a lesson cannot be undone.`,
                {
                    centered: true,
                    confirmButtonClass: "btn btn-danger",
                    cancelButtonClass: "btn btn-primary",
                    confirmButtonText: "Delete"
                }
            )
            .subscribe((result) => {
                if(result === ConfirmationDialogResult.Confirm) {
                    this.lessonService
                        .delete(lessonId)
                        .pipe(takeUntil(this.unsubscribe$))
                        .subscribe({
                            next:() => {
                                this.reloadPageContent();
                                this.notificationService.showSuccessMessage("Lesson deleted", 'Success');
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
                },
                error: () =>
                    this.notificationService.showErrorMessage('Something went wrong', 'Error')
            });
    }

    getCourseUnits() {
        if(this.currentCourseUser.courseRole === CourseRole.Admin) {
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
        else {
            this.unitService.getCoursePublishedUnits(this.currentCourse.id)
                .pipe(takeUntil(this.unsubscribe$))
                .subscribe({
                    next:(units) => {
                        this.units = units;
                    },
                    error: () =>
                        this.notificationService.showErrorMessage('Something went wrong', 'Error')
                });
        }
    }

    getCourseLessons() {
        if(this.currentCourseUser.courseRole === CourseRole.Admin) {
            this.lessonService.getCourseLessonsWithoutUnit(this.currentCourse.id)
                .pipe(takeUntil(this.unsubscribe$))
                .subscribe({
                    next: (lessons) => {
                        this.lessons = lessons;
                    },
                    error: () =>
                        this.notificationService.showErrorMessage('Something went wrong', 'Error')
                });
        }
        else {
            this.lessonService.getPublishedCourseLessonsAsync(this.currentCourse.id)
                .pipe(takeUntil(this.unsubscribe$))
                .subscribe({
                    next: (lessons) => {
                        this.lessons = lessons;
                    },
                    error: () =>
                        this.notificationService.showErrorMessage('Something went wrong', 'Error')
                });
        }
    }

    publishLesson(lessonId: number, publish: boolean) {
        this.lessonService.publishLesson(lessonId, {publish} as PublishLesson)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(() => {
                this.reloadPageContent();
                this.notificationService.showSuccessMessage('Lesson published', 'Success');
            })
    }

    addToUnit(unitId: number) {
        const modalRef = this.modalService.open(AddToUnitDialogComponent, { centered: true })
        modalRef.componentInstance.unit = this.units.find(u => u.id === unitId);
        modalRef.result
            .then((result) => {
                if(result) {
                    this.reloadPageContent();
                }
            }).catch(noop);
    }

    removeFromUnit(unitId: number, lessonId: number) {
        this.lessonService.lessonToUnit({unitId: unitId, lessonId: lessonId, add: false} as LessonToUnit)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(() => {
                this.reloadPageContent();
                this.notificationService.showSuccessMessage('Lesson removed', 'Success');
            })
    }

    getCurrentCourseUser(courseId: number) {
        this.courseService
            .getCourseUser(courseId)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((cu) => {
                this.currentCourseUser = cu;
                this.reloadPageContent();
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

    private reloadPageContent() {
        this.getCourseLessons();
        this.getCourseUnits();
    }

    showLessonDescription(lesson: Lesson) {
        this.confirmationDialogService
            .openConfirmationDialog(
                `${lesson.title}`,
                `${lesson.description}`,
                {
                    centered: true,
                    cancelButton: false,
                    confirmButtonText: "Ok"
                }
            )
    }
}
