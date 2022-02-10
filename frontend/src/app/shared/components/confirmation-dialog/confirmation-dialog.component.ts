import { Component, Input, OnInit } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { ConfirmationDialogOptions } from '@core/models/confirmation-dialog/confirmation-dialog-options';
import { ConfirmationDialogResult } from '@core/models/confirmation-dialog/confirmation-dialog-result';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
    templateUrl: './confirmation-dialog.component.html',
    styleUrls: ['./confirmation-dialog.component.sass']
})
export class ConfirmationDialogComponent implements OnInit {

    @Input() title : string;
    @Input() content : string;
    @Input() options? : Partial<ConfirmationDialogOptions>;

    constructor(public modal: NgbActiveModal, public sanitizer: DomSanitizer) {}

    ngOnInit(): void {
    }

    closeDismiss(){
        this.modal.dismiss(ConfirmationDialogResult.Dismiss);
    }

    closeCancel(){
        this.modal.close(ConfirmationDialogResult.Cancel);
    }

    closeConfirm(){
        this.modal.close(ConfirmationDialogResult.Confirm);
    }
}
