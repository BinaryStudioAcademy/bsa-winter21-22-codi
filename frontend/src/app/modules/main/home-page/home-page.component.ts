import {Component, OnInit} from '@angular/core';
import {ProjectCreationModalService} from '@core/services/project-creation-modal.service';
import {ProjectService} from "@core/services/project.service";
import {BaseComponent} from "@core/base/base.component";
import {takeUntil} from "rxjs";
import {NotificationService} from "@core/services/notification.service";
import {ProjectWithLanguage} from "@core/models/project/project-with-language";
import {IconLanguageHelper} from "@shared/helpers/icon-language-helper";
import {Language} from "@core/enums/language";
import {GithubRepository} from "@core/models/github/github-repository";
import {CredentialsService} from "@core/services/credentials.service";
import {GithubService} from "@core/services/github.service";
import {GitClone} from "@core/models/git/git-clone";
import {Router} from "@angular/router";

@Component({
    selector: 'app-home-page',
    templateUrl: './home-page.component.html',
    styleUrls: ['./home-page.component.sass'],
})
export class HomePageComponent extends BaseComponent implements OnInit{

    projects: ProjectWithLanguage[] = [];
    repositories: GithubRepository[] = [];
    userHasToken: boolean = false;
    loadingRepo: boolean = false;
    loadingProjects: boolean = false;
    loading: boolean = false;

    constructor(
        private projectDialogService: ProjectCreationModalService,
        private projectService: ProjectService,
        private notificationService: NotificationService,
        private credentialsService: CredentialsService,
        private githubService: GithubService,
        private router: Router
    )
    {
        super();
    }

    createProject() {
        this.projectDialogService.openCreateDialog();
    }

    ngOnInit(): void {
        this.loadingRepo = true;
        this.loadingProjects = true;
        this.getRecentProjects();
        this.credentialsService
            .checkIfUserHasToken()
            .subscribe((res) => {
                this.userHasToken = res;
                if(res) {
                    this.getRecentRepositories();
                }
            });
    }

    private getRecentRepositories() {
        this.githubService
            .getUserRepositories()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next:(repositories) =>
                {
                    this.loadingRepo = false;
                    this.repositories = repositories;
                },
                error:() => {
                    this.loadingRepo = false;
                    this.notificationService.showErrorMessage('Something went wrong', 'Error');
                }
            })
    }

    private getRecentProjects() {
        this.projectService.getCurrentUserLastProjects()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next:(projects) => {
                    this.loadingProjects = false;
                    this.projects = projects;
                },
                error:() => {
                    this.loadingProjects = false;
                    this.notificationService.showErrorMessage('Something went wrong', 'Error');
                }
            });
    }

    iconForLanguage(language: Language)  {
        return IconLanguageHelper(language);
    }

    forEnum(index: number) {
        return Object.values(Language)[index];
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
