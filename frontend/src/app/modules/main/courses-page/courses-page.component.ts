import { Component, OnInit } from '@angular/core';
import { NgbModal } from "@ng-bootstrap/ng-bootstrap";
import { NewCourseDialogComponent } from "@modules/main/courses-page/new-course-dialog/new-course-dialog.component";
import {
    NewOrganizationDialogComponent
} from "@modules/main/courses-page/new-organization-dialog/new-organization-dialog.component";
import { BaseComponent } from "@core/base/base.component";
import { Organization } from "@core/models/organization/organization";
import { AuthService } from "@core/services/auth.service";
import { OrganizationService } from "@core/services/organization.service";
import { User } from "@core/models/user/user";
import { switchMap, takeUntil} from "rxjs";
import { NotificationService } from "@core/services/notification.service";
import { ConfirmationDialogService } from "@core/services/confirmation-dialog.service";
import { CourseService } from "@core/services/course.service";
import {
    UpdateOrganizationDialogComponent
} from "@modules/main/courses-page/update-organization-dialog/update-organization-dialog.component";
import { noop } from "@shared/common/utils";
import { ConfirmationDialogResult } from '@core/models/confirmation-dialog/confirmation-dialog-result';

@Component({
    selector: 'app-courses-page',
    templateUrl: './courses-page.component.html',
    styleUrls: ['./courses-page.component.sass'],
})
export class CoursesPageComponent extends BaseComponent implements OnInit {

    user = {} as User;
    organizations: Organization[] = [];

    constructor(
        private modalService: NgbModal,
        private authService: AuthService,
        private organizationService: OrganizationService,
        private coursesService: CourseService,
        private notificationService: NotificationService,
        private confirmationDialogService: ConfirmationDialogService
    )
    {
        super();
    }

    ngOnInit(): void {
        this.authService
            .getCurrentUser()
            .pipe(
                switchMap((u) => {
                    this.user = u;
                    return this.organizationService.getUserOrganizations(u.id);
                }),
                takeUntil(this.unsubscribe$)
            )
            .subscribe((orgs) => this.organizations = orgs);
    }

    createCourse(organization: Organization) {
        const modalRef = this.modalService.open(NewCourseDialogComponent, { centered: true })
        modalRef.componentInstance.org = organization;
        modalRef.result
            .then((result) => {
                if(result) {
                    this.reloadOrganizations();
                }
            }).catch(noop);
    }

    deleteCourse(courseId: number, orgId: number) {
        let org = this.organizations.find(o => o.id === orgId);
        let courseName = org?.courses.find(c => c.id === courseId)?.displayName;
        this.confirmationDialogService
            .openConfirmationDialog(
                `Delete ${courseName}?`,
                `Deleting will remove the Course from this Organization,
                and all Repls and Folders in this Course will be deleted.
                Are you sure you want to delete this Course?
                Be careful, deleting a course cannot be undone.`,
                {
                    centered: true,
                    confirmButtonClass: "btn btn-danger",
                    cancelButtonClass: "btn btn-primary",
                    confirmButtonText: "Delete"
                }
            )
            .subscribe((result) => {
                if(result === ConfirmationDialogResult.Confirm) {
                    this.coursesService
                        .delete(courseId)
                        .pipe(takeUntil(this.unsubscribe$))
                        .subscribe({
                            next:() => {
                                this.reloadOrganizations();
                                this.notificationService.showSuccessMessage("Course deleted", 'Success');
                            },
                            error:() => this.notificationService.showErrorMessage("Something went wrong...", 'Error')
                        });
                }
            });
    }

    leaveCourse(courseId: number, orgId: number) {
        let org = this.organizations.find(o => o.id === orgId);
        let courseName = org?.courses.find(c => c.id === courseId)?.displayName;
        this.confirmationDialogService
            .openConfirmationDialog(
                `Leave ${courseName}?`,
                `Are you sure you want to leave this Course?
                You will lose access to all of the Course's Repls and Folders.`,
                {
                    centered: true,
                    confirmButtonClass: "btn btn-danger",
                    cancelButtonClass: "btn btn-primary",
                    confirmButtonText: "Leave"
                }
            )
            .subscribe((result) => {
                if(result === ConfirmationDialogResult.Confirm) {
                    this.coursesService
                        .leaveCourse(courseId)
                        .pipe(takeUntil(this.unsubscribe$))
                        .subscribe({
                            next:() => {
                                this.reloadOrganizations();
                                this.notificationService.showSuccessMessage("You have left course", 'Success');
                            },
                            error:() => this.notificationService.showErrorMessage("Something went wrong...", 'Error')
                        });
                }
            });
    }

    createOrganization() {
        this.modalService.open(NewOrganizationDialogComponent, { centered: true }).result
            .then((result) => {
                if(result) {
                    this.reloadOrganizations();
                }
            }).catch(noop);
    }

    updateOrganization(org: Organization) {
        const modalRef = this.modalService.open(UpdateOrganizationDialogComponent, { centered: true });
        modalRef.componentInstance.org = org;
        modalRef.result
            .then((result) => {
                if(result) {
                    this.reloadOrganizations();
                }
            }).catch(noop);
    }

    deleteOrganization(id: number) {
        let org = this.organizations.find(o => o.id === id);
        let orgName = org?.name;
        let message = (org!.courses.length > 0)
            ? `This Organization has active Course(s).
            Do you really want to delete Organization with all these Course(s)?
            This process cannot be undone.`
            : `Do you really want to delete this Organization?
            This process cannot be undone.`;
        this.confirmationDialogService
            .openConfirmationDialog(
                `Delete ${orgName}?`,
                message,
                {
                    centered: true,
                    confirmButtonClass: "btn btn-danger",
                    cancelButtonClass: "btn btn-primary",
                    confirmButtonText: "Delete"
                }
            )
            .subscribe((result) => {
                if(result === ConfirmationDialogResult.Confirm) {
                    this.organizationService
                        .delete(id)
                        .pipe(takeUntil(this.unsubscribe$))
                        .subscribe({
                            next:() => {
                                this.reloadOrganizations();
                                this.notificationService.showSuccessMessage("Organization deleted", 'Success');
                            },
                            error:() => this.notificationService.showErrorMessage("Something went wrong...", 'Error')
                        });
                }
            });
    }

    private reloadOrganizations() {
        this.organizationService
            .getUserOrganizations(this.user.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((resp) => this.organizations = resp);
    }
}
