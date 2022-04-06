import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class ConsoleService {
    receivedOutput$ = new Subject<void>();
    startProject$ = new Subject<void>();
    toggleConsole$ = new Subject<void>();
    stopContainer$ = new Subject<void>();

    constructor() {}

    receivedOutput() {
        this.receivedOutput$.next();
    }

    startProject() {
        this.startProject$.next();
    }

    toggleConsole() {
        this.toggleConsole$.next();
    }

    stopContainer() {
        this.stopContainer$.next();
    }
}
