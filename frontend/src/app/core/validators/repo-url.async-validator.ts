import { GithubService } from "@core/services/github.service";
import { AbstractControl, AsyncValidatorFn, ValidationErrors } from "@angular/forms";
import { map, Observable, switchMap, timer } from "rxjs";
import { GithubRepositoryLink } from "@core/models/github/github-repository-link";

export function repoUrlAsyncValidator(githubService: GithubService): AsyncValidatorFn {
    return (control: AbstractControl): Promise<ValidationErrors | null> | Observable<ValidationErrors | null> => {
        return timer(500).pipe(
            switchMap(() => githubService.isRepositoryAccessible({link: control.value} as GithubRepositoryLink)),
            map((res) => res ? null : { isRepositoryNonAccessible: true })
        );
    };
};
