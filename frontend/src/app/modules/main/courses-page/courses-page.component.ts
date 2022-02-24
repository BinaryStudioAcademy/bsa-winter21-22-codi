import {Component, OnInit} from '@angular/core';
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
import { EventService } from "@core/services/event.service";
import { ConfirmationDialogService } from "@core/services/confirmation-dialog.service";
import { CourseService } from "@core/services/course.service";
import {
    UpdateOrganizationDialogComponent
} from "@modules/main/courses-page/update-organization-dialog/update-organization-dialog.component";

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
        private eventService: EventService,
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
            .subscribe((orgs) => {this.organizations = orgs.body!
                console.log(this.organizations)});

        this.eventService.userChangedEvent$.pipe(takeUntil(this.unsubscribe$)).subscribe((user) => {
            this.user = user;
        });
    }

    createCourse(organization: Organization) {
        const modalRef = this.modalService.open(NewCourseDialogComponent, { centered: true })
        modalRef.componentInstance.org = organization;
        modalRef.result
            .then((result) => {
                if(result) {
                    this.organizations.find(o => o.id === organization.id)?.courses.push(result);
                }
            })
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
                }
            )
            .subscribe((result) => {
                if(!result) {
                    this.coursesService
                        .delete(courseId)
                        .pipe(takeUntil(this.unsubscribe$))
                        .subscribe(
                            next => {
                                org!.courses = org?.courses.filter(c => c.id !== courseId)!;
                                this.notificationService.showSuccessMessage("Course successfully deleted");
                            },
                            error => this.notificationService.showErrorMessage("Something went wrong...")
                        );
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
                }
            )
            .subscribe((result) => {
                if(!result) {
                    this.coursesService
                        .leaveCourse(courseId)
                        .pipe(takeUntil(this.unsubscribe$))
                        .subscribe(
                            next => {
                                org!.courses = org?.courses.filter(c => c.id !== courseId)!;
                                if(!org!.courses.length){
                                    this.organizations = this.organizations.filter(o => o.id !== org!.id);
                                }
                                this.notificationService.showSuccessMessage("You have successfully left course");
                            },
                            error => this.notificationService.showErrorMessage("Something went wrong...")
                        );
                }
            });
    }

    createOrganization() {
        this.modalService.open(NewOrganizationDialogComponent, { centered: true }).result
            .then((result) => {
                if(result) {
                    this.organizations.push(result);
                }
            })
    }

    updateOrganization(orgId: number) {
        const modalRef = this.modalService.open(UpdateOrganizationDialogComponent, { centered: true });
        modalRef.componentInstance.orgId = orgId;
        modalRef.result
            .then((result) => {
                if(result) {
                    let org = this.organizations.find(org => org.id === orgId);
                    org!.name = result.name;
                }
            })
    }

    deleteOrganization(id: number) {
        let org = this.organizations.find(o => o.id === id);
        let orgName = org?.name;
        this.confirmationDialogService
            .openConfirmationDialog(
                `Delete ${orgName}?`,
                `Deleting ${orgName} will remove access to the Organization.\nThis cannot be undone!`,
                {
                    centered: true,
                }
            )
            .subscribe((result) => {
                if(!result) {
                    if(org!.courses.length <= 0) {
                        this.organizationService
                            .delete(id)
                            .pipe(takeUntil(this.unsubscribe$))
                            .subscribe(
                                next => {
                                    this.organizations = this.organizations.filter(o => o.id !== id);
                                    this.notificationService.showSuccessMessage("Organization successfully deleted");
                                },
                                error => this.notificationService.showErrorMessage("Something went wrong...")
                            );
                    }
                    else {
                        this.notificationService.showErrorMessage("You must delete all courses before this action")
                    }
                }
            });
    }
}
