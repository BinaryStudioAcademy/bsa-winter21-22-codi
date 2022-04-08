import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { ConfirmationDialogResult } from '@core/models/confirmation-dialog/confirmation-dialog-result';
import { Project } from '@core/models/project/project';
import { ConfirmationDialogService } from '@core/services/confirmation-dialog.service';
import { NotificationService } from '@core/services/notification.service';
import { ProjectCreationModalService } from '@core/services/project-creation-modal.service';
import { ProjectService } from '@core/services/project.service';
import { takeUntil } from 'rxjs';
import { Router } from "@angular/router";
import {GithubRepository} from "@core/models/github/github-repository";
import {CredentialsService} from "@core/services/credentials.service";
import {GithubService} from "@core/services/github.service";
import {GitClone} from "@core/models/git/git-clone";

@Component({
    templateUrl: './my-projects-page.component.html',
    styleUrls: ['./my-projects-page.component.sass']
})
export class MyProjectsPageComponent extends BaseComponent implements OnInit {

    loading = false;
    projects: Project[] = []
    repositories: GithubRepository[] = [];
    userHasToken: boolean = false;

    constructor(
        private projectService: ProjectService,
        private notificationService: NotificationService,
        private projectDialogService: ProjectCreationModalService,
        private confirmationDialogService: ConfirmationDialogService,
        public router: Router,
        private credentialsService: CredentialsService,
        private githubService: GithubService
    ) {
        super();
    }

    ngOnInit(): void {
        this.loadProjects();
        this.getRepositories();
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

    private getRepositories() {
        this.githubService
            .getUserRepositories()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((repositories) => {
                this.repositories = repositories;
            })
    }

    importedGit(title: string, url: string) {
        this.loading = true;
        let cloneProject = {
            title: title,
            url: url
        } as GitClone;
        this.projectService.gitProjectImport(cloneProject)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next:(resp) => {
                    this.loading = false;
                    this.router.navigate(['workspace', resp.id]).then(() => {
                        this.notificationService.showSuccessMessage(`Project "${resp.title}" created`, 'Success');
                    });
                },
                error:() => {
                    this.loading = false;
                    this.notificationService.showErrorMessage('Something was wrong', 'Error');
                }
            });
    }
}
