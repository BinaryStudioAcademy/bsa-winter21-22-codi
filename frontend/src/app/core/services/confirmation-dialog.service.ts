import { Injectable } from '@angular/core';
import { ConfirmationDialogOptions } from '@core/models/confirmation-dialog/confirmation-dialog-options';
import { ConfirmationDialogResult } from '@core/models/confirmation-dialog/confirmation-dialog-result';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ConfirmationDialogComponent } from '@shared/components/confirmation-dialog/confirmation-dialog.component';
import { mapTo, Observable, race } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class ConfirmationDialogService {

    constructor(private modalService: NgbModal) {}

    openConfirmationDialog(title: string, content: string, options?: Partial<ConfirmationDialogOptions>) : Observable<ConfirmationDialogResult> {
        let modalRef = this.modalService.open(ConfirmationDialogComponent);
        let component = modalRef.componentInstance as ConfirmationDialogComponent;

        component.title = title;
        component.content = content;
        component.options = options;

        return race([modalRef.closed, modalRef.dismissed.pipe(mapTo(ConfirmationDialogResult.Dismiss))]);
    }

    dismissAll() {
        this.modalService.dismissAll(ConfirmationDialogResult.Dismiss);
    }
}
