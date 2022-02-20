import { Injectable } from '@angular/core';
import { HttpRequest, HttpHandler, HttpInterceptor } from '@angular/common/http';
import { switchMap, take } from 'rxjs';
import { AuthService } from '@core/services/auth.service';

@Injectable()
export class JwtInterceptor implements HttpInterceptor {
    constructor(private authService: AuthService) { }

    intercept(request: HttpRequest<unknown>, next: HttpHandler) {
        return this.authService.getAuthIdToken().pipe(
            take(1),
            switchMap((authIdToken: string | null) => {
                if (!authIdToken) { return next.handle(request); }
                const authReq = request.clone({ setHeaders: { Authorization: `Bearer ${authIdToken}` } });
                return next.handle(authReq);
            }),
        );
    }
}
