import {UserService} from "@core/services/user.service";
import {AbstractControl, AsyncValidatorFn, ValidationErrors} from "@angular/forms";
import {Observable, timer} from "rxjs";
import {map, switchMap} from "rxjs/operators";

export function emailAsyncValidator(userService: UserService): AsyncValidatorFn {
    return (control: AbstractControl): Promise<ValidationErrors | null> | Observable<ValidationErrors | null> => {
        return timer(500)
            .pipe(
                switchMap(() => userService.getUserEmail(control.value)),
                map((res ) => {
                    return  res ? { emailExists: true } : null
                }));
    };
}
