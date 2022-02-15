import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import {Observable, switchMap, take } from 'rxjs';
import {AuthService} from "@core/services/auth.service";

@Injectable()
export class JwtInterceptor implements HttpInterceptor {

  constructor(private authService: AuthService) {}

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {

    return this.authService.getAuthIdToken().pipe(
      take(1),
      switchMap((authIdToken: string | null) => {
        if(!authIdToken) { return next.handle(request); }
        const authReq = request.clone({ setHeaders: { Authorization: `Bearer ${authIdToken}` } });
        return next.handle(authReq);
      })
    );

  }
}
