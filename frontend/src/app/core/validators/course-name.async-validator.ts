import {AbstractControl, AsyncValidatorFn, ValidationErrors} from "@angular/forms";
import {Observable, switchMap, timer} from "rxjs";
import {CourseService} from "@core/services/course.service";
import {map} from "rxjs/operators";

export function CourseNameAsyncValidator (courseService: CourseService): AsyncValidatorFn {
    return (control: AbstractControl): Promise<ValidationErrors | null> | Observable<ValidationErrors | null> => {
        return timer(500).pipe(
            switchMap(() => courseService.getNameForValidator(control.value)),
            map((resp) => {
                return resp ? { courseNameExists: true} : null
            }));
    };
}
