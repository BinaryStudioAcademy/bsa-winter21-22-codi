import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { NgbActiveModal, NgbTypeahead } from "@ng-bootstrap/ng-bootstrap";
import {
    debounceTime,
    distinctUntilChanged,
    filter,
    map,
    merge,
    Observable,
    OperatorFunction,
    Subject,
    takeUntil
} from "rxjs";
import { FormControl, FormGroup, Validators } from "@angular/forms";
import { Template } from "@core/models/template/template";
import { Unit } from "@core/models/unit/unit";
import { NotificationService } from "@core/services/notification.service";
import { ProjectService } from "@core/services/project.service";
import { Course } from "@core/models/course/course";
import { BaseComponent } from "@core/base/base.component";
import { regexs } from "@shared/constants/regexs";
import { TemplateService } from "@core/services/template.service";
import { UnitService } from "@core/services/unit.service";
import { Lesson } from "@core/models/lesson/lesson";
import { CreateLesson } from "@core/models/lesson/create-lesson";
import { LessonService } from "@core/services/lesson.service";

@Component({
    selector: 'app-create-lesson-dialog',
    templateUrl: './create-lesson-dialog.component.html',
    styleUrls: ['./create-lesson-dialog.component.sass']
})
export class CreateLessonDialogComponent extends BaseComponent implements OnInit {
    @Input() course: Course;

    @ViewChild('templateInstance', { static: true }) templateInstance: NgbTypeahead;
    templatesFocus$ = new Subject<string>();
    templatesClick$ = new Subject<string>();

    @ViewChild('unitInstance', { static: true }) unitInstance: NgbTypeahead;
    unitsFocus$ = new Subject<string>();
    unitsClick$ = new Subject<string>();

    minPickerDate = {
        year: new Date().getFullYear(),
        month: new Date().getMonth() + 1,
        day: new Date().getDate()
    };

    templates: Template[] = []
    units: Unit[] = []

    form: FormGroup;

    constructor(public modal: NgbActiveModal,
        private notificationService: NotificationService,
        private projectService: ProjectService,
        private templateService: TemplateService,
        private unitService: UnitService,
        private lessonService: LessonService) {
        super();
    }

    ngOnInit(): void {
        this.loadTemplates();
        this.loadUnits();
        this.form = new FormGroup({
            title: new FormControl('',
                [
                    Validators.required,
                    Validators.minLength(2),
                    Validators.maxLength(50),
                    Validators.pattern(regexs.title),
                ]),
            template: new FormControl('', Validators.required),
            description: new FormControl('',
                [
                    Validators.maxLength(140),
                    Validators.pattern(regexs.title)
                ]),
            unit: new FormControl(''),
            dueDate: new FormControl(null)
        });
    }

    loadTemplates() {
        this.templateService.getNamesTemplate()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((resp) => {
                this.templates = resp;
            })
    }

    loadUnits() {
        this.unitService.getCourseUnits(this.course.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((resp) => {
                this.units = resp;
            })
    }

    resultTemplateFormatter = (template: { name: string }) => template.name;
    templateInputFormatter = (template: { name: string }) => template.name;

    searchTemplates: OperatorFunction<string, readonly Template[]> = (text$: Observable<string>) => {
        const debouncedText$ = text$.pipe(debounceTime(200), distinctUntilChanged());
        const clicksWithClosedPopup$ = this.templatesClick$.pipe(filter(() => !this.templateInstance?.isPopupOpen()));
        return merge(debouncedText$, this.templatesFocus$, clicksWithClosedPopup$).pipe(
            map(term => (term === '' ? this.templates
                : this.templates.filter(t => t.name.toLowerCase().indexOf(term.toLowerCase()) > -1)).slice(0, 25))
        );
    }

    resultUnitFormatter = (unit: { title: string }) => unit.title;
    unitInputFormatter = (unit: { title: string }) => unit.title;

    searchUnits: OperatorFunction<string, readonly Unit[]> = (text$: Observable<string>) => {
        const debouncedText$ = text$.pipe(debounceTime(200), distinctUntilChanged());
        const clicksWithClosedPopup$ = this.unitsClick$.pipe(filter(() => !this.unitInstance?.isPopupOpen()));
        return merge(debouncedText$, this.unitsFocus$, clicksWithClosedPopup$).pipe(
            map(term => (term === '' ? this.units
                : this.units.filter(u => u.title.toLowerCase().indexOf(term.toLowerCase()) > -1)).slice(0, 25))
        );
    }

    submit() {
        let formValue = this.form.value;
        let selectedDate: Date | undefined;
        if(formValue.dueDate) {
            let pickerDate = formValue.dueDate;
            selectedDate = new Date(pickerDate.year, pickerDate.month, pickerDate.day);
        }

        let createdLesson: Lesson;
        let createLesson = {
            title: formValue.title,
            description: formValue.description,
            courseId: this.course.id,
            unitId: formValue.unit.id,
            templateId: formValue.template.id,
            dueDate: selectedDate
        } as CreateLesson;
        this.lessonService.create(createLesson)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next:(unit) => {
                    createdLesson = unit;
                    this.notificationService.showSuccessMessage('Lesson created', 'Success');
                },
                error:() => {
                    this.notificationService.showErrorMessage('Failed to create lesson', 'Error');
                },
                complete: () => {
                    this.modal.close(createdLesson);
                }
            });
    }
}
