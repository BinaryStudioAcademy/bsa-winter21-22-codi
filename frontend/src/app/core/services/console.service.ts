import { Injectable } from '@angular/core';
import { CodiHttpClientService } from "@core/services/codi-http-client.service";
import { Subject } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class ConsoleService {
    start$ = new Subject<string>();

    constructor(private httpService: CodiHttpClientService) {}

    startProject() {
        this.start$.next("started");
    }
}
