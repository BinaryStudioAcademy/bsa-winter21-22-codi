import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from "@ng-bootstrap/ng-bootstrap";
import { NotificationService } from "@core/services/notification.service";
import { OrganizationService } from "@core/services/organization.service";
import { FormControl, FormGroup, Validators } from "@angular/forms";
import { BaseComponent } from "@core/base/base.component";
import { CreateOrganization } from "@core/models/organization/create-organization";
import { takeUntil } from "rxjs";
import { Organization } from "@core/models/organization/organization";
import { regexs } from "@shared/constants/regexs";
import { WhiteSpaceValidator } from "@shared/validators/whitespace.validator";

@Component({
    selector: 'app-new-organization-dialog',
    templateUrl: './new-organization-dialog.component.html'
})
export class NewOrganizationDialogComponent extends BaseComponent implements OnInit {
    form: FormGroup;

    constructor(
        public modal: NgbActiveModal,
        private notificationsService: NotificationService,
        private organizationService: OrganizationService
    ) {
        super();
    }

    ngOnInit(): void {
        this.form = new FormGroup({
            name: new FormControl('',
                [
                    Validators.required,
                    Validators.minLength(5),
                    Validators.maxLength(100),
                    Validators.pattern(regexs.title),
                    WhiteSpaceValidator.noWhiteSpace
                ]),
        });
    }

    createOrganization() {
        let createdOrg: Organization | null = null;
        let formValue = this.form.value;
        let createOrganization =
            {
                name: formValue.name,
            } as CreateOrganization;
        this.organizationService
            .create(createOrganization)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                (org) => {
                    createdOrg = org;
                    this.notificationsService.showSuccessMessage('Organization successfully created');
                },
                error => this.notificationsService.showErrorMessage('Failed to create organization'),
                () => this.modal.close(createdOrg)
            );
    }

    closeDialog() {
        this.modal.close();
    }
}
