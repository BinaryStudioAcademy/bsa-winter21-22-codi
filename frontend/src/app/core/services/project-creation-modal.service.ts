import {Injectable} from '@angular/core';
import {NgbModal} from "@ng-bootstrap/ng-bootstrap";
import {CreateReplModalComponent} from "@shared/components/create-repl-modal/create-repl-modal.component";
import {TemplateService} from "@core/services/template.service";

@Injectable({
    providedIn: 'root'
})
export class ProjectCreationModalService {

    constructor(private modalService: NgbModal) {}

    openReplModal() {
        const modalRef = this.modalService.open(CreateReplModalComponent, {centered: true});
    }
}