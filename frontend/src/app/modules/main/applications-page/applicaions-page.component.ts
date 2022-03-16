import { HttpResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { App } from '@core/models/app/app';
import { PaginatedList } from '@core/models/paginated-list/paginated-list';
import { AppService } from '@core/services/app.service';
import { NotificationService } from '@core/services/notification.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { forkJoin, Observable, Subject, takeUntil } from 'rxjs';
import { PublishAppDialogComponent } from './publish-app-dialog/publish-app-dialog.component';

class AppCollection {
    appsObservable: Observable<PaginatedList<App>>
    tite: string
    seeAllLink: string
    apps: PaginatedList<App> | null
}

@Component({
    selector: 'app-applications',
    templateUrl: './applicaions-page.component.html',
    styleUrls: ['./applicaions-page.component.sass'],
})
export class ApplicationsPageComponent extends BaseComponent implements OnInit {

    public loading = false;
    public appsCollections: AppCollection[];

    constructor(private modalService: NgbModal,
        private appService: AppService,
        private notificationService: NotificationService) {
        super();

        this.appsCollections = [
            {
                appsObservable: this.appService.getAllApps(1, 3),
                tite: "Just published",
                seeAllLink: "/main/apps/tag/all",
                apps: null
            },
            {
                appsObservable: this.appService.getAppsWithTag(19, 1, 3),
                tite: ".NET",
                seeAllLink: "/main/apps/tag/19",
                apps: null
            },
            {
                appsObservable: this.appService.getAppsWithTag(10, 1, 3),
                tite: "iOS",
                seeAllLink: "/main/apps/tag/10",
                apps: null
            }
        ]
    }

    ngOnInit(): void {
        this.loading = true;

        this.appsCollections.forEach(collection => {
            collection.appsObservable
                .pipe(takeUntil(this.unsubscribe$))
                .subscribe({
                    next: (resp) => {
                        this.loading = false;
                        collection.apps = resp;
                    },
                    error: (error) => {
                        this.loading = false;
                        this.notificationService.showErrorMessage(error.message, "Error")
                    }

                })
        });
    }

    publichApp() {
        let modalRef = this.modalService.open(PublishAppDialogComponent, { centered: true });
        modalRef.closed.subscribe({
            next: (resp) => {
                if (resp) {
                    this.appsCollections[0].apps?.items.unshift(resp);
                }
            }
        })
    }
}
