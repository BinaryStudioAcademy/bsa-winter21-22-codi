import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { ConfirmationDialogResult } from '@core/models/confirmation-dialog/confirmation-dialog-result';
import { Project } from '@core/models/project/project';
import { ConfirmationDialogService } from '@core/services/confirmation-dialog.service';
import { NotificationService } from '@core/services/notification.service';
import { ProjectCreationModalService } from '@core/services/project-creation-modal.service';
import { ProjectService } from '@core/services/project.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { CreateProjectDialogComponent } from '@shared/components/create-project-dialog/create-project-dialog.component';
import { takeUntil } from 'rxjs';
import { ActivatedRoute, Router } from "@angular/router";

@Component({
    templateUrl: './my-projects-page.component.html',
    styleUrls: ['./my-projects-page.component.sass']
})
export class MyProjectsPageComponent extends BaseComponent implements OnInit {

    public loading = false;
    public projects: Project[] = []
    public gitprojects: Project[] = []

    constructor(private projectService: ProjectService,
        private notificationService: NotificationService,
        private projectDialogService: ProjectCreationModalService,
        private confirmationDialogService: ConfirmationDialogService,
        public router: Router
        ) {
        super();
    }

    ngOnInit(): void {
        this.loadProjects();
        this.loadGitProjects();
    }

    loadProjects() {
        this.loading = true;

        this.projectService
            .getCurrentUserProjects()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (resp) => {
                    this.projects = resp ?? [];
                    this.loading = false;
                },
                error: (error) => {
                    this.notificationService.showErrorMessage(error.message, "Error")
                }

            })
    }

    loadGitProjects() {
        this.loading = true;

        this.projectService
            .getCurrentUserGitProjects()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (resp) => {
                    this.gitprojects = resp ?? [];
                    this.loading = false;
                },
                error: (error) => {
                    this.notificationService.showErrorMessage(error.message, "Error")
                }

            })
    }

    createProject() {
        let modalRef = this.projectDialogService.openCreateDialog();
        modalRef.closed.subscribe({
            next: (resp: Project) => {
                if (resp) {
                    this.loadProjects();
                }
            }
        });
    }

    deleteProject(project: Project) {

        this.confirmationDialogService
            .openConfirmationDialog(
                `Delete ${project.title}?`,
                `Do you really want to delete your project? This process cannot be undone.`,
                {
                    centered: true,
                    confirmButtonClass: "btn btn-danger",
                    cancelButtonClass: "btn btn-primary",
                    confirmButtonText: "Delete"
                }
            )
            .subscribe((result) => {
                if (result === ConfirmationDialogResult.Confirm) {
                    this.deleteProjectRequest(project.id)
                }
            });
    }

    deleteProjectRequest(projectId: number) {
        this.projectService
            .deleteProject(projectId)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: () => {
                    this.loadProjects();
                    this.notificationService.showSuccessMessage("Project successfully deleted", "Success");
                },
                error: (error) => {
                    this.notificationService.showErrorMessage(error.message, "Error")
                }
            });
    }
}
