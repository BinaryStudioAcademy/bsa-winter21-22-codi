import { Injectable } from '@angular/core';
import { ProjectOutput } from '@core/models/build/project-output';
import { HubConnection } from '@microsoft/signalr';
import { Subject, Subscription } from 'rxjs';
import { SignalRHubFactoryService } from './signalr-hub-factory.service';

@Injectable({
    providedIn: 'root',
})
export class BuildHubService {
    readonly hubUrl = 'buildHub';

    private hubConnection: HubConnection;

    readonly messages = new Subject<ProjectOutput>();

    private subscriptions: Subscription[] = [];

    constructor(
        private hubFactory: SignalRHubFactoryService,
    ) {
    }

    async start() {
        this.hubConnection = this.hubFactory.createHub(this.hubUrl);
        await this.init();
    }

    listenMessages(action: (output: ProjectOutput) => void) {
        this.subscriptions.push(this.messages.subscribe({ next: action }));
    }

    async stop() {
        await this.hubConnection?.stop();
        this.subscriptions.forEach(s => s.unsubscribe());
    }

    private async init() {
        await this.hubConnection.start()
            .then(() => console.info(`"${this.hubFactory}" successfully started.`))
            .catch(() => console.info(`"${this.hubFactory}" failed.`));

        this.hubConnection.on('ReceiveProjectOutput', (output: ProjectOutput) => {
            this.messages.next(output);
        });
    }
}
