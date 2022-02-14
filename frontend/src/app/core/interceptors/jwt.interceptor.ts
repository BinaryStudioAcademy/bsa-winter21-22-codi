import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';
import {AuthService} from "@core/services/auth.service";

@Injectable()
export class JwtInterceptor implements HttpInterceptor {



  constructor(private authService: AuthService) {}

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {

    const currentUser = this.authService.currentUser$;
    const accessToken = this.authService.token;
    const isLoggedIn = currentUser && accessToken;

    if (isLoggedIn) {
      request = request.clone({ setHeaders: { Authorization: `Bearer ${accessToken}` } })
    }
    return next.handle(request);
  }
}
