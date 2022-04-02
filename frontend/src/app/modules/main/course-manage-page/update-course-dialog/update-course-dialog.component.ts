import {Component, Input, OnInit} from '@angular/core';
import {FormControl, FormGroup, Validators} from "@angular/forms";
import {regexs} from "@shared/constants/regexs";
import {WhiteSpaceValidator} from "@shared/validators/whitespace.validator";
import {Course} from "@core/models/course/course";
import {NgbActiveModal} from "@ng-bootstrap/ng-bootstrap";
import {NotificationService} from "@core/services/notification.service";
import {UpdateCourse} from "@core/models/course/update-course";
import {CourseService} from "@core/services/course.service";
import {takeUntil} from "rxjs";
import {BaseComponent} from "@core/base/base.component";


@Component({
    selector: 'app-update-course-dialog',
    templateUrl: './update-course-dialog.component.html',
    styleUrls: ['./update-course-dialog.component.sass']
})
export class UpdateCourseDialogComponent extends BaseComponent implements OnInit {
    @Input() course: Course;
    form: FormGroup;
    imageFile: File;
    forImage: string;

    constructor(
        public modal: NgbActiveModal,
        private notificationService: NotificationService,
        private courseService: CourseService
    )
    {
        super();
    }

    ngOnInit(): void {
        this.form = new FormGroup({
            displayName: new FormControl('',
                [
                    Validators.required,
                    Validators.minLength(5),
                    Validators.maxLength(60),
                    Validators.pattern(regexs.title),
                    WhiteSpaceValidator.noWhiteSpace
                ]),
            description: new FormControl('',
                [
                    Validators.maxLength(140),
                    Validators.pattern(regexs.title)
                ]),
        });
        this.form.patchValue(this.course);
    }

    updateCourse() {
        let formValue = this.form.value;
        let updatedCourse: Course;
        let updateCourse = {
            id: this.course.id,
            displayName: formValue.displayName,
            description: formValue.description,
            avatar: this.forImage ? this.forImage : this.course.avatar
        } as UpdateCourse;
        this.courseService.update(updateCourse)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next:(course) => {
                    updatedCourse = course;
                },
                error:() => {
                    this.modal.close();
                    this.notificationService.showErrorMessage('Failed to update organization', 'Error');
                },
                complete: () => {
                    this.modal.close(updatedCourse);
                    this.notificationService.showSuccessMessage('Course updated', 'Success');
                }
            });
    }

    handleFileInput(target: any) {
        this.imageFile = target.files[0];

        if (!this.imageFile) {
            target.value = '';
            return;
        }

        if (this.imageFile.size / 1000000 > 5) {
            this.notificationService.showErrorMessage(`Image can't be heavier than ~5MB`);
            target.value = '';
            return;
        }

        const reader = new FileReader();
        reader.addEventListener('load', () => (this.course.avatar = reader.result as string));
        reader.readAsDataURL(this.imageFile);
        reader.onloadend = () => {
            this.forImage = reader.result as string;
        };
    }
}
