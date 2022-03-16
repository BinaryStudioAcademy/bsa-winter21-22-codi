import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { Project } from '@core/models/project/project';
import { NotificationService } from '@core/services/notification.service';
import { ProjectCreationModalService } from '@core/services/project-creation-modal.service';
import { ProjectService } from '@core/services/project.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { CreateProjectDialogComponent } from '@shared/components/create-project-dialog/create-project-dialog.component';
import { takeUntil } from 'rxjs';

@Component({
    templateUrl: './my-projects-page.component.html',
    styleUrls: ['./my-projects-page.component.sass']
})
export class MyProjectsPageComponent extends BaseComponent implements OnInit {

    public loading = false;
    public projects: Project[] = []

    constructor(private projectService: ProjectService,
        private notificationService: NotificationService,
        private projectDialogService: ProjectCreationModalService) {
        super();
    }

    ngOnInit(): void {
        this.loadProjects();
    }

    loadProjects() {
        this.projectService
            .getCurrentUserProjects()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (resp) => {
                    this.projects = resp ?? [];
                },
                error: (error) => {
                    this.notificationService.showErrorMessage(error.message, "Error")
                }

            })
    }

    createProject() {
        let modalRef = this.projectDialogService.openCreateDialog();
        modalRef.closed.subscribe({
            next: (resp) => {
                if (resp) {
                    this.projects.unshift(resp);
                }
            }
        })
    }
}
