import { Component, OnInit, ViewChild} from '@angular/core';
import { NgbActiveModal, NgbModal, NgbTypeahead } from "@ng-bootstrap/ng-bootstrap";
import { ProjectService } from "@core/services/project.service";
import { NotificationService } from "@core/services/notification.service";
import { CreateReplModalComponent } from "@shared/components/create-repl-modal/create-repl-modal.component";
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
import { CreateProject } from "@core/models/project/create-project";
import { FormControl, FormGroup } from "@angular/forms";
import { BaseComponent } from "@core/base/base.component";
import { GithubService } from "@core/services/github.service";
import { Repository } from "@core/models/repository";

@Component({
    selector: 'app-import-github-project-modal',
    templateUrl: './import-github-project-modal.component.html',
    styleUrls: ['./import-github-project-modal.component.sass']
})
export class ImportGithubProjectModalComponent extends BaseComponent implements OnInit {

    @ViewChild('instance', {static: true}) instance: NgbTypeahead;
    focus$ = new Subject<string>();
    click$ = new Subject<string>();
    repositories: Repository[] = [];
    project = {} as CreateProject;
    form: FormGroup;

    constructor(
        public activeModal: NgbActiveModal,
        private modalService: NgbModal,
        private githubService: GithubService,
        private projectService: ProjectService,
        private notificationService: NotificationService
    ) {
        super();
    }

    ngOnInit(): void {
        this.form = new FormGroup({
            privacy: new FormControl(false),
        });
        this.githubService.getUserRepos()
            .pipe(
                takeUntil(this.unsubscribe$),
            )
            .subscribe((repos) => {
                console.log(repos)
                //this.repositories = repos;
            })
    }

    search: OperatorFunction<string, readonly Repository[]> = (text$: Observable<string>) => {
        const debouncedText$ = text$.pipe(debounceTime(200), distinctUntilChanged());
        const clicksWithClosedPopup$ = this.click$.pipe(filter(() => !this.instance.isPopupOpen()));
        const inputFocus$ = this.focus$;
        return merge(debouncedText$, inputFocus$, clicksWithClosedPopup$).pipe(
            map(term => (term === '' ? this.repositories
                : this.repositories.filter(t => t.name.toLowerCase().indexOf(term.toLowerCase()) > -1)).slice(0, 100))
        );
    }

    formatter = (x: {name: string}) => x.name;

    openProjectFromTemplate() {
        this.activeModal.close();
        this.modalService.open(CreateReplModalComponent, {centered: true});
    }

    isGithubTokenExists() {
        return this.githubService.isGithubTokenExists();
    }
}
