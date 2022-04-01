import { Component, OnDestroy, OnInit } from '@angular/core';
import { BroadcastHubService } from '@core/hubs/broadcast-hub.service';
import { BuildHubService } from '@core/hubs/build-hub.service';
import { NotificationService } from '@core/services/notification.service';

@Component({
    selector: 'app-home',
    templateUrl: './main-page.component.html',
    styleUrls: ['./main-page.component.sass'],
})
export class MainComponent implements OnInit, OnDestroy {
    constructor(private broadcastHub: BroadcastHubService,
        private buildHub: BuildHubService,
        private notifications: NotificationService) { }

    async ngOnInit() {
        await this.broadcastHub.start();
        this.broadcastHub.listenMessages((msg) => {
            console.log(`The next broadcast message was received: ${msg}`);
        });

        await this.buildHub.start();
        this.buildHub.listenMessages((output) => {
            this.notifications.showSuccessMessage("Output: " + output.output, "Project id: " + output.projectId.toString());
        });
    }

    ngOnDestroy() {
        this.broadcastHub.stop();
        this.buildHub.stop();
    }
}
