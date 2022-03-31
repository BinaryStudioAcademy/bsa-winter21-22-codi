import { HttpClient, HttpErrorResponse, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '@env/environment';
import { Observable, throwError } from 'rxjs';
import { Params } from "@angular/router";

@Injectable({
    providedIn: 'root',
})
export class CodiHttpClientService {
    public baseUrl: string = environment.coreUrl;

    public headers = new HttpHeaders();

    constructor(private http: HttpClient) { }

    public getHeaders(): HttpHeaders {
        return this.headers;
    }

    public getRequest<T>(url: string, httpParams?: Params): Observable<T> {
        return this.http.get<T>(this.buildUrl(url), {
            headers: this.getHeaders(),
            params: httpParams,
        });
    }

    public postRequest<T>(url: string, payload: object): Observable<T> {
        return this.http.post<T>(this.buildUrl(url), payload, {
            headers: this.getHeaders(),
        });
    }

    public putRequest<T>(url: string, payload: object): Observable<T> {
        return this.http.patch<T>(this.buildUrl(url), payload, {
            headers: this.getHeaders(),
        });
    }

    public patchRequest<T>(url: string, payload: object): Observable<T> {
        return this.http.patch<T>(this.buildUrl(url), payload, {
            headers: this.getHeaders(),
        });
    }

    public deleteRequest<T>(url: string, httpParams?: Params): Observable<T> {
        return this.http.delete<T>(this.buildUrl(url), {
            headers: this.getHeaders(),
            params: httpParams,
        });
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

    private handleError(error: HttpErrorResponse): Observable<any> {
        let errorMessage = '';

        if (error.error instanceof ErrorEvent) {
            //error client
            errorMessage = error.error.message;
        } else {
            //error server
            errorMessage = `Error: ${error.status}, ` + `message: ${error.message}`;
        }

        return throwError(() => errorMessage);
    }
}
