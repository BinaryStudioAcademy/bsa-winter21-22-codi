import {Component, OnDestroy, OnInit, ViewChild} from '@angular/core';
import {NgbActiveModal, NgbTypeahead} from "@ng-bootstrap/ng-bootstrap";
import {debounceTime, distinctUntilChanged, filter, map, merge, Observable, OperatorFunction, Subject, takeUntil} from "rxjs";
import {TemplateService} from "@core/services/template.service";
import {Template} from "@core/models/template/template";
import {FormControl, FormGroup, Validators} from "@angular/forms";
import {ProjectService} from "@core/services/project.service";
import {CreateProject} from "@core/models/project/create-project";
import {NotificationService} from "@core/services/notification.service";
import {regexs} from "@shared/constants/regexs";

@Component({
    templateUrl: './create-repl-modal.component.html',
    styleUrls: ['./create-repl-modal.component.sass']
})
export class CreateReplModalComponent implements OnInit, OnDestroy {

    @ViewChild('instance', {static: true}) instance: NgbTypeahead;
    focus$ = new Subject<string>();
    click$ = new Subject<string>();
    templates: Template [] = [];
    unsubscribe$ = new Subject<void>();
    project = {} as CreateProject;
    form: FormGroup;

    constructor(
        public activeModal: NgbActiveModal,
        private templateService: TemplateService,
        private projectService: ProjectService,
        private notificationService: NotificationService
    ) {}

    ngOnInit(): void {
        this.getTemplates();
        this.form = new FormGroup({
            projectName: new FormControl('',
                [
                    Validators.required,
                    Validators.minLength(2),
                    Validators.maxLength(15),
                    Validators.pattern(regexs.username),
                ]),
            privacy: new FormControl(false),
            template: new FormControl('', Validators.required)
        });
    }

    ngOnDestroy(): void {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
    }

    search: OperatorFunction<string, readonly Template[]> = (text$: Observable<string>) => {
        const debouncedText$ = text$.pipe(debounceTime(200), distinctUntilChanged());
        const clicksWithClosedPopup$ = this.click$.pipe(filter(() => !this.instance.isPopupOpen()));
        const inputFocus$ = this.focus$;
        return merge(debouncedText$, inputFocus$, clicksWithClosedPopup$).pipe(
            map(term => (term === '' ? this.templates
                : this.templates.filter(t => t.name.toLowerCase().indexOf(term.toLowerCase()) > -1)).slice(0, 100))
        );
    }

    formatter = (x: {name: string}) => x.name;

    getTemplates() {
        this.templateService.getNamesTemplate()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                (resp) => {
                    if(resp.body) this.templates = resp.body
                })
    }

    submit() {
        this.project.isPublic = this.form.value.privacy;
        this.project.templateId = this.form.value.template.id;
        this.project.title = this.form.value.projectName;
        this.projectService.createProject(this.project)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (resp) => {
                    let proj = JSON.stringify(resp.body?.title)
                    this.activeModal.close()
                    this.notificationService.showSuccessMessage('Project created: ' + proj, 'Good job!')
                },
                error: () => {
                    this.activeModal.close()
                    this.notificationService.showErrorMessage('Something was wrong', 'Error')
                }});
    }
}
