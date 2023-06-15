import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import {catchError, Observable, throwError} from 'rxjs';
import { Router } from "@angular/router";
import { ToastrService } from "ngx-toastr";

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {

  constructor(private route: Router, private toastr: ToastrService) {}

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    return next.handle(request).pipe(
      catchError(error => {
        if (error) {
          switch (error.status) {
            case 400:
              this.toastr.error(error.error.message, error.error.statusCode);
              break;
            case 401:
              this.toastr.error(error.error.message, error.error.statusCode);
              break;
            case 404:
              this.route.navigateByUrl('/not-found');
              break;
            case 500:
              this.route.navigateByUrl('/server-error');
              break;
          }
        }
        return throwError(error);
      })
    );
  }
}
