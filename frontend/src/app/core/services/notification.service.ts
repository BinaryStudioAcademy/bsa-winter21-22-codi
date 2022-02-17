import { Injectable } from '@angular/core';
import { IndividualConfig, ToastrService } from 'ngx-toastr';

@Injectable({
    providedIn: 'root'
})
export class NotificationService {

    constructor(private toastr: ToastrService) {}

    public showSuccessMessage(message?: string, title?: string, config?: Partial<IndividualConfig>) {
        this.toastr.success(message, title, config);
    }

    public showInfoMessage(message?: string, title?: string, config?: Partial<IndividualConfig>) {
        this.toastr.info(message, title, config);
    }

    public showWarningMessage(warning?: string, title?: string, config?: Partial<IndividualConfig>) {
        this.toastr.warning(warning, title, config);
    }

    public showErrorMessage(info?: string, title?: string, config?: Partial<IndividualConfig>) {
        this.toastr.error(info, title, config);
    }
}
