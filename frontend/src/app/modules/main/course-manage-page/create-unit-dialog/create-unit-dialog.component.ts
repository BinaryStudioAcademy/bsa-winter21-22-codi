import {Component, Input, OnInit} from '@angular/core';
import {FormControl, FormGroup, Validators} from "@angular/forms";
import {NgbActiveModal} from "@ng-bootstrap/ng-bootstrap";
import {NotificationService} from "@core/services/notification.service";
import {UnitService} from "@core/services/unit.service";
import {BaseComponent} from "@core/base/base.component";
import {regexs} from "@shared/constants/regexs";
import {WhiteSpaceValidator} from "@shared/validators/whitespace.validator";
import {takeUntil} from "rxjs";
import {CreateUnit} from "@core/models/unit/create-unit";
import {Unit} from "@core/models/unit/unit";
import {Course} from "@core/models/course/course";

@Component({
  selector: 'app-create-unit-dialog',
  templateUrl: './create-unit-dialog.component.html'
})
export class CreateUnitDialogComponent extends BaseComponent implements OnInit {
    @Input() course: Course;
    form: FormGroup;

    constructor(
        public modal: NgbActiveModal,
        private notificationService: NotificationService,
        private unitService: UnitService
    )
    {
        super();
    }

    ngOnInit(): void {
        this.form = new FormGroup({
            title: new FormControl('',
                [
                    Validators.required,
                    Validators.minLength(5),
                    Validators.maxLength(60),
                    Validators.pattern(regexs.title),
                    WhiteSpaceValidator.noWhiteSpace
                ])
        });
    }


    createUnit() {
        let formValue = this.form.value;
        let createdUnit: Unit;
        let createUnit = {
            title: formValue.title,
            courseId: this.course.id
        } as CreateUnit;
        this.unitService.create(createUnit)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next:(unit) => {
                    createdUnit = unit;
                    this.notificationService.showSuccessMessage('Unit created', 'Success');
                },
                error:() => {
                    this.notificationService.showErrorMessage('Failed to create unit', 'Error');
                },
                complete: () => {
                    this.modal.close(createUnit);
                }
            });
    }
}
