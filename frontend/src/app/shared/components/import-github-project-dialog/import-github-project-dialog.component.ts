import { Component, OnInit, ViewChild} from '@angular/core';
import { NgbActiveModal, NgbModal, NgbTypeahead } from "@ng-bootstrap/ng-bootstrap";
import { ProjectService } from "@core/services/project.service";
import { NotificationService } from "@core/services/notification.service";
import {
    debounceTime,
    distinctUntilChanged,
    filter,
    map,
    merge,
    Observable,
    OperatorFunction,
    Subject, takeUntil
} from "rxjs";
import { FormControl, FormGroup, Validators } from "@angular/forms";
import { BaseComponent } from "@core/base/base.component";
import { CreateProjectDialogComponent } from "@shared/components/create-project-dialog/create-project-dialog.component";
import { GitClone } from "@core/models/git/git-clone";
import { GithubRepository } from "@core/models/github/github-repository";
import { GithubService } from "@core/services/github.service";
import { CredentialsService } from "@core/services/credentials.service";
import { GithubUser } from "@core/models/github/github-user";
import {repoUrlAsyncValidator} from "@core/validators/repo-url.async-validator";

@Component({
    selector: 'app-import-github-project-dialog',
    templateUrl: './import-github-project-dialog.component.html',
    styleUrls: ['./import-github-project-dialog.component.sass']
})
export class ImportGithubProjectDialogComponent extends BaseComponent implements OnInit {

    @ViewChild('instance', { static: true }) instance: NgbTypeahead;
    focus$ = new Subject<string>();
    click$ = new Subject<string>();
    githubUser: GithubUser;
    repositories: GithubRepository[] = [];
    repositoryUrl: string;
    form: FormGroup;
    userHasToken = false;

    githubRepoSection = false;
    urlSection = false;

    loading = false;

    constructor(
        public activeModal: NgbActiveModal,
        private modalService: NgbModal,
        private projectService: ProjectService,
        private githubService: GithubService,
        private credentialsService: CredentialsService,
        private notificationService: NotificationService
    ) {
        super();
    }

    ngOnInit(): void {
        this.form = new FormGroup({
            isPublic: new FormControl(false)
        });

        this.credentialsService
            .checkIfUserHasToken()
            .subscribe((res) => {
                this.userHasToken = res;
                if(res) {
                    this.getRepositories();
                    this.githubRadioClicked();
                }
                else {
                    this.urlRadioClicked();
                }
            });
    }

    resultFormatter = (repository: { name: string }) => repository.name;
    inputFormatter = (repository: { name: string }) => repository.name;

    search: OperatorFunction<string, readonly GithubRepository[]> = (text$: Observable<string>) => {
        const debouncedText$ = text$.pipe(debounceTime(200), distinctUntilChanged());
        const clicksWithClosedPopup$ = this.click$.pipe(filter(() => !this.instance?.isPopupOpen()));
        return merge(debouncedText$, this.focus$, clicksWithClosedPopup$).pipe(
            map(term => (term === '' ? this.repositories
                : this.repositories.filter(r => r.name.toLowerCase().indexOf(term.toLowerCase()) > -1)).slice(0, 25))
        );
    }

    submit() {
        this.loading = true;
        let gitClone: GitClone;
        if (this.githubRepoSection) {
            let repository = this.form.value.repository;
            gitClone = {
                title: repository.name,
                url: repository.url,
                isPublic: this.form.value.isPublic
            } as GitClone;
        }
        else {
            let repositoryUrl = this.form.value.repositoryUrl;
            gitClone = {
                title: this.getNameFromUrl(repositoryUrl),
                url: repositoryUrl,
                isPublic: this.form.value.isPublic
            } as GitClone;
        }

        this.projectService
            .gitProjectImport(gitClone)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                (resp) => {
                    this.loading = false;
                    this.activeModal.close(resp);
                    this.notificationService.showSuccessMessage(`Project "${resp.title}" created`, 'Success');
                },
                () => {
                    this.loading = false;
                    this.activeModal.close();
                    this.notificationService.showErrorMessage('Something was wrong', 'Error');
                });
    }

    openProjectFromTemplate() {
        this.activeModal.close();
        this.modalService.open(CreateProjectDialogComponent, {centered: true});
    }

    githubRadioClicked() {
        if (!this.userHasToken) {
            return;
        }

        this.githubRepoSection = true;
        this.urlSection = false;

        if (this.form.controls['repositoryUrl']) {
            this.form.removeControl('repositoryUrl');
        }

        this.form.addControl('repository', new FormControl('',
            [
                Validators.required
            ]
        ),
        );
    }

    urlRadioClicked() {
        this.urlSection = true;
        this.githubRepoSection = false;

        if (this.form.controls['repository']) {
            this.form.removeControl('repository');
        }

        this.form.addControl('repositoryUrl', new FormControl('',
            [
                Validators.required,
                Validators.pattern(`https:\/\/github\.com\/[A-Za-z0-9-]+\/[A-Za-z0-9_.-]+`)
            ],
            [
                repoUrlAsyncValidator(this.githubService),
            ]),
        );
    }

    private getRepositories() {
        this.githubService
            .getUserRepositories()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((repositories) => {
                this.repositories = repositories;
            })
    }

    private getNameFromUrl(url: string) {
        return url.substring(url.lastIndexOf('/') + 1, url.length);
    }
}