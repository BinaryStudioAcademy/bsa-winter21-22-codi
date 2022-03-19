import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from "@angular/forms";
import { NgbActiveModal } from "@ng-bootstrap/ng-bootstrap";
import { NotificationService } from "@core/services/notification.service";
import { OrganizationService } from "@core/services/organization.service";
import { takeUntil } from "rxjs";
import { BaseComponent } from "@core/base/base.component";
import { UpdateOrganization } from "@core/models/organization/update-organization";
import { Organization } from "@core/models/organization/organization";
import { regexs } from "@shared/constants/regexs";
import { WhiteSpaceValidator } from "@shared/validators/whitespace.validator";

@Component({
    selector: 'app-update-organization-dialog',
    templateUrl: './update-organization-dialog.component.html'
})
export class UpdateOrganizationDialogComponent extends BaseComponent implements OnInit {
    @Input() org: Organization;
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
        this.form.patchValue(this.org);
    }

    updateOrganization() {
        let updatedOrg: UpdateOrganization | null = null;
        let formValue = this.form.value;
        let updateOrganization =
            {
                id: this.org.id,
                name: formValue.name,
            } as UpdateOrganization;
        this.organizationService
            .update(updateOrganization)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                (org) => {
                    updatedOrg = org;
                    this.notificationsService.showSuccessMessage('Organization updated', 'Success');
                },
                error => this.notificationsService.showErrorMessage('Failed to update organization', 'Error'),
                () => this.modal.close(updatedOrg)
            );
    }

    closeDialog() {
        this.modal.close();
    }
}
