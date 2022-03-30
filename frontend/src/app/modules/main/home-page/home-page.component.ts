import {Component, OnInit} from '@angular/core';
import {ProjectCreationModalService} from '@core/services/project-creation-modal.service';
import {ProjectService} from "@core/services/project.service";
import {BaseComponent} from "@core/base/base.component";
import {takeUntil} from "rxjs";
import {NotificationService} from "@core/services/notification.service";
import {ProjectWithLanguage} from "@core/models/project/project-with-language";
import {IconLanguageHelper} from "@shared/helpers/icon-language-helper";
import {Languages} from "@shared/constants/languages";

@Component({
    selector: 'app-home-page',
    templateUrl: './home-page.component.html',
    styleUrls: ['./home-page.component.sass'],
})
export class HomePageComponent extends BaseComponent implements OnInit{

    projects: ProjectWithLanguage[] = [];

    constructor(
        private projectDialogService: ProjectCreationModalService,
        private projectService: ProjectService,
        private notificationService: NotificationService,
    )
    {
        super();
    }

    createProject() {
        this.projectDialogService.openCreateDialog();
    }

    ngOnInit(): void {
        this.getAllProjects()
    }

    getAllProjects() {
        this.projectService.getCurrentUserLastProjects()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next:(projects) =>
                    this.projects = projects,
                error:() =>
                    this.notificationService.showErrorMessage('Something went wrong', 'Error')
            });
    }

    iconForLanguage(extension: number)  {
        return IconLanguageHelper(extension);
    }

    forEnum(index: number) {
        return Object.values(Languages)[index];
    }
}
