import { AbstractControl, AsyncValidatorFn, ValidationErrors } from '@angular/forms';
import { Observable, timer} from 'rxjs';
import { switchMap, map } from 'rxjs/operators';
import { CredentialsService } from "@core/services/credentials.service";
import { AccessToken } from "@core/models/credentials/access-token";

export function userCredentialsAsyncValidator(credentialService: CredentialsService): AsyncValidatorFn  {
    return (control: AbstractControl): Promise<ValidationErrors | null> | Observable<ValidationErrors | null> => {
        return timer(500).pipe(
            switchMap(() => credentialService.checkIfTokenValid(control.value as AccessToken)),
            map((res) => res.isSucceed ? null : { invalidToken: res })
        );
    };
};
