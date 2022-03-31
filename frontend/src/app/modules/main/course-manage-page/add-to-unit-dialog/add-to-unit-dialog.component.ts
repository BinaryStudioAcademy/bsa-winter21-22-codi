import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { Lesson } from "@core/models/lesson/lesson";
import { NgbActiveModal, NgbModal, NgbTypeahead } from "@ng-bootstrap/ng-bootstrap";
import {
    debounceTime,
    distinctUntilChanged,
    filter, map,
    merge,
    Observable,
    OperatorFunction,
    Subject,
    takeUntil
} from "rxjs";
import { FormControl, FormGroup, Validators } from "@angular/forms";
import { Unit } from "@core/models/unit/unit";
import { NotificationService } from "@core/services/notification.service";
import { BaseComponent } from "@core/base/base.component";
import { UnitService } from "@core/services/unit.service";
import { LessonService } from "@core/services/lesson.service";
import { LessonToUnit } from "@core/models/lesson/lesson-to-unit";

@Component({
  selector: 'app-add-to-unit-dialog',
  templateUrl: './add-to-unit-dialog.component.html'
})
export class AddToUnitDialogComponent extends BaseComponent implements OnInit {
    @Input() unit: Unit;
    @ViewChild('instance', { static: true }) instance: NgbTypeahead;
    focus$ = new Subject<string>();
    click$ = new Subject<string>();
    lessons: Lesson[] = [];
    form: FormGroup;

    constructor(
        public activeModal: NgbActiveModal,
        private modalService: NgbModal,
        private unitService: UnitService,
        private lessonService: LessonService,
        private notificationService: NotificationService
    ) {
        super();
    }

    ngOnInit(): void {
        this.loadLessons();
        this.form = new FormGroup({
            lesson: new FormControl('', Validators.required)
        });
    }

    resultFormatter = (unit: { title: string }) => unit.title;
    inputFormatter = (unit: { title: string }) => unit.title;

    search: OperatorFunction<string, readonly Lesson[]> = (text$: Observable<string>) => {
        const debouncedText$ = text$.pipe(debounceTime(200), distinctUntilChanged());
        const clicksWithClosedPopup$ = this.click$.pipe(filter(() => !this.instance?.isPopupOpen()));
        return merge(debouncedText$, this.focus$, clicksWithClosedPopup$).pipe(
            map(term => (term === '' ? this.lessons
                : this.lessons.filter(l => l.title.toLowerCase().indexOf(term.toLowerCase()) > -1)).slice(0, 25))
        );
    }

    submit() {
        let formValue = this.form.value;
        let lessonToUnit = {
            lessonId: formValue.lesson.id,
            unitId: this.unit.id,
            add: true
        } as LessonToUnit
        this.lessonService.lessonToUnit(lessonToUnit)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: () => {
                    this.activeModal.close(true)
                    this.notificationService.showSuccessMessage(` "${formValue.lesson.title}" added to unit`, 'Success');
                },
                error: () => {
                    this.activeModal.close(false)
                    this.notificationService.showErrorMessage('Something was wrong', 'Error')
                }
            });
    }

    loadLessons() {
        this.lessonService.getCourseLessonsWithoutUnit(this.unit.courseId)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((resp) => {
                this.lessons = resp;
            })
    }
}
