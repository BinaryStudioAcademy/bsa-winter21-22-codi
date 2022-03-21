import { Component } from '@angular/core';
import { ProjectCreationModalService } from '@core/services/project-creation-modal.service';

import { SideNavService } from '@core/services/side-nav.service';

@Component({
    selector: 'app-side-nav',
    templateUrl: './side-nav.component.html',
    styleUrls: ['./side-nav.component.sass'],
})
export class SideNavComponent {
    constructor(public sideNavService: SideNavService, private projectDialogService: ProjectCreationModalService) { }

    createProject() {
        this.projectDialogService.openCreateDialog();
    }
}
