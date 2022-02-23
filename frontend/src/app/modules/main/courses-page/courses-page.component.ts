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
import {flatMap, switchMap, takeUntil} from "rxjs";
import { NotificationService } from "@core/services/notification.service";
import { EventService } from "@core/services/event.service";
import {ConfirmationDialogComponent} from "@shared/components/confirmation-dialog/confirmation-dialog.component";
import { ConfirmationDialogService } from "@core/services/confirmation-dialog.service";

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
                switchMap((u) => this.organizationService.getUserOrganizations(u.id)),
                takeUntil(this.unsubscribe$)
            )
            .subscribe((orgs) => this.organizations = orgs.body!);

        this.eventService.userChangedEvent$.pipe(takeUntil(this.unsubscribe$)).subscribe((user) => {
            this.user = user;
        });
    }

    createCourse() {
        this.modalService.open(NewCourseDialogComponent, { centered: true });
    }

    createOrganization() {
        this.modalService.open(NewOrganizationDialogComponent, { centered: true }).result
            .then((result) => {
                console.log(result)
                if(result !== null) {
                    this.organizations.push(result);
                }
            })
    }

    deleteOrganization(id: number) {
        let orgName = this.organizations.find(o => o.id === id)?.name;
        this.confirmationDialogService
            .openConfirmationDialog(
                `Delete ${orgName}`,
                `Deleting ${orgName} will remove access to the Organization.\nThis cannot be undone!`,
                {
                    centered: true,
                }
            )
            .subscribe((result) => {
                if(!result) {
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
            });
    }

    private getOrganizations(id: number) {
        this.organizationService
            .getUserOrganizations(id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((organizations) => this.organizations = organizations.body!);
    }
}
