import { Component, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser';
import { ConfirmationDialogOptions } from '@core/models/confirmation-dialog/confirmation-dialog-options';
import { ConfirmationDialogResult } from '@core/models/confirmation-dialog/confirmation-dialog-result';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
    templateUrl: './confirmation-dialog.component.html',
    styleUrls: ['./confirmation-dialog.component.sass']
})
export class ConfirmationDialogComponent implements OnInit {

    title : string;
    content: string | SafeHtml;
    options? : Partial<ConfirmationDialogOptions>;

    constructor(public modal: NgbActiveModal, public sanitizer: DomSanitizer) {}

    setContent(title: string, content: string, options?: Partial<ConfirmationDialogOptions>) {
        this.title = title;
        this.content = options?.allowHtmlContent
            ? this.sanitizer.bypassSecurityTrustHtml(content)
            : content;
        this.options = options;
    }

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
