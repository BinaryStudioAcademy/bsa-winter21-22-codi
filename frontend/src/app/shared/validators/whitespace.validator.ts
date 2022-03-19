import { AbstractControl, ValidationErrors } from '@angular/forms';

export class WhiteSpaceValidator {
    static noWhiteSpace(control: AbstractControl): ValidationErrors | null {
        const value = control.value;
        if (!value) {
            return null;
        }

        const whiteSpaces = /^\S+(?: \S+)*$/.test(value);
        if(!whiteSpaces) {
            return {noWhiteSpace: true}
        }
        return null;
    }
}
