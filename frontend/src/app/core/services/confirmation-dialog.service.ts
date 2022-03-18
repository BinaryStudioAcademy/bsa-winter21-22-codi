import { Injectable } from '@angular/core';
import { ConfirmationDialogOptions } from '@core/models/confirmation-dialog/confirmation-dialog-options';
import { ConfirmationDialogResult } from '@core/models/confirmation-dialog/confirmation-dialog-result';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ConfirmationDialogComponent } from '@shared/components/confirmation-dialog/confirmation-dialog.component';
import { mapTo, Observable, race } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class ConfirmationDialogService {
    constructor(private modalService: NgbModal) {}

    openConfirmationDialog(title: string, content: string,
        options?: Partial<ConfirmationDialogOptions>): Observable<ConfirmationDialogResult> {
        const modalRef = this.modalService.open(ConfirmationDialogComponent, {centered: options?.centered ?? false});
        const component = modalRef.componentInstance as ConfirmationDialogComponent;

        component.setContent(title, content, options);

        return race([modalRef.closed, modalRef.dismissed.pipe(mapTo(ConfirmationDialogResult.Dismiss))]);
    }

    dismissAll() {
        this.modalService.dismissAll(ConfirmationDialogResult.Dismiss);
    }
}
