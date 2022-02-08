import { Injectable } from '@angular/core';
import {HttpClient, HttpErrorResponse, HttpHeaders, HttpResponse} from "@angular/common/http";
import {environment} from "@env/environment";
import {Observable, retry, throwError} from "rxjs";
import {catchError} from "rxjs/operators";

@Injectable({
  providedIn: 'root'
})
export class CodiHttpClientService {

  public baseUrl: string = environment.coreUrl;
  public headers = new HttpHeaders();

  constructor(private http: HttpClient) { }

  public getHeaders(): HttpHeaders {
    return this.headers;
  }

  public getFullRequest<T>(url: string, httpParams?: any): Observable<HttpResponse<T>> {
    return this.http.get<T>(this.buildUrl(url), { observe: 'response', headers: this.getHeaders(), params: httpParams })
      .pipe(
        retry(2),
        catchError(this.handleError)
      );

  }

  public postFullRequest<T>(url: string, payload: object): Observable<HttpResponse<T>> {
    return this.http.post<T>(this.buildUrl(url), payload, { headers: this.getHeaders(), observe: 'response' })
      .pipe(
        retry(2),
        catchError(this.handleError)
      );
  }

  public putFullRequest<T>(url: string, payload: object): Observable<HttpResponse<T>> {
    return this.http.put<T>(this.buildUrl(url), payload, { headers: this.getHeaders(), observe: 'response' })
      .pipe(
        retry(2),
        catchError(this.handleError)
      );
  }

  public deleteFullRequest<T>(url: string, httpParams?: any): Observable<HttpResponse<T>> {
    return this.http.delete<T>(this.buildUrl(url), { headers: this.getHeaders(), observe: 'response', params: httpParams })
      .pipe(
        retry(2),
        catchError(this.handleError)
      );
  }

  public buildUrl(url: string): string {
    if (url.startsWith('http://') || url.startsWith('https://')) {
      return url;
    }
    return this.baseUrl + url;
  }
  public prepareData(payload: object): string {
    return JSON.stringify(payload);
  }

  private handleError(error: HttpErrorResponse){
    let errorMessage = '';

    if(error.error instanceof ErrorEvent){
      //error client
      errorMessage = error.error.message;
    } else {
      //error server
      errorMessage = `Error: ${error.status}, ` + `message: ${error.message}`;
    }

    return throwError(errorMessage);
  }

}
