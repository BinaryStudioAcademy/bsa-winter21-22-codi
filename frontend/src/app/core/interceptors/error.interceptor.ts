import { Injectable } from '@angular/core';
import {
    HttpHandler,
    HttpInterceptor,
    HttpErrorResponse,
    HttpRequest,
} from '@angular/common/http';
import { throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable({
    providedIn: 'root',
})
export class ErrorInterceptor implements HttpInterceptor {
    constructor() { }

    handleError(error: HttpErrorResponse) {
        return throwError(() => new Error(error.message ?? 'Something went wrong'));
    }

    intercept(req: HttpRequest<unknown>, next: HttpHandler) {
        return next.handle(req).pipe(catchError(this.handleError));
    }
}
