import { Component, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { NgbActiveModal, NgbTypeahead } from "@ng-bootstrap/ng-bootstrap";
import { debounceTime, distinctUntilChanged, filter, map, merge, Observable, OperatorFunction, Subject, takeUntil } from "rxjs";
import { TemplateService } from "@core/services/template.service";
import { Template } from "@core/models/template/template";
import { FormControl, FormGroup, Validators } from "@angular/forms";
import { ProjectService } from "@core/services/project.service";
import { CreateProject } from "@core/models/project/create-project";
import { NotificationService } from "@core/services/notification.service";
import { regexs } from "@shared/constants/regexs";
import { BaseComponent } from '@core/base/base.component';

@Component({
    templateUrl: './create-project-dialog.component.html',
    styleUrls: ['./create-project-dialog.component.sass']
})
export class CreateProjectDialogComponent extends BaseComponent implements OnInit, OnDestroy {

    @ViewChild('instance', { static: true }) instance: NgbTypeahead;
    focus$ = new Subject<string>();
    click$ = new Subject<string>();
    templates: Template[] = [];
    form: FormGroup;

    constructor(
        public activeModal: NgbActiveModal,
        private templateService: TemplateService,
        private projectService: ProjectService,
        private notificationService: NotificationService
    ) {
        super();
    }

    ngOnInit(): void {
        this.getTemplates();
        this.form = new FormGroup({
            title: new FormControl('',
                [
                    Validators.required,
                    Validators.minLength(2),
                    Validators.maxLength(100),
                    Validators.pattern(regexs.username),
                ]),
            isPublic: new FormControl(false),
            template: new FormControl('', Validators.required)
        });
    }

    resultFormatter = (template: { name: string }) => template.name;
    inputFormatter = (template: { name: string }) => template.name;

    search: OperatorFunction<string, readonly Template[]> = (text$: Observable<string>) => {
        const debouncedText$ = text$.pipe(debounceTime(200), distinctUntilChanged());
        const clicksWithClosedPopup$ = this.click$.pipe(filter(() => !this.instance.isPopupOpen()));
        return merge(debouncedText$, this.focus$, clicksWithClosedPopup$).pipe(
            map(term => (term === '' ? this.templates
                : this.templates.filter(t => t.name.toLowerCase().indexOf(term.toLowerCase()) > -1)).slice(0, 25))
        );
    }

    getTemplates() {
        this.templateService.getNamesTemplate()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                (resp) => {
                    if (resp) this.templates = resp;
                })
    }

    submit() {
        let newProject = this.form.value as CreateProject;
        newProject.templateId = this.form.value.template.id;

        this.projectService.createProject(newProject)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (resp) => {
                    this.activeModal.close(resp)
                    this.notificationService.showSuccessMessage(`Project "${resp.title}" created`, 'Success')
                },
                error: () => {
                    this.activeModal.close()
                    this.notificationService.showErrorMessage('Something was wrong', 'Error')
                }
            });
    }
}
