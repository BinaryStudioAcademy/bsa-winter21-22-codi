import { Component } from '@angular/core';
import { ProjectCreationModalService } from '@core/services/project-creation-modal.service';

@Component({
    selector: 'app-home-page',
    templateUrl: './home-page.component.html',
    styleUrls: ['./home-page.component.sass'],
})
export class HomePageComponent {

    constructor(private projectDialogService: ProjectCreationModalService) {}

    createProject() {
        this.projectDialogService.openCreateDialog();
    }
}
