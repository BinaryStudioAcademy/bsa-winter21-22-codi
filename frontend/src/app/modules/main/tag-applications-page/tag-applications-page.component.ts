import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { App } from '@core/models/app/app';
import { PaginatedList } from '@core/models/paginated-list/paginated-list';
import { TagInfo } from '@core/models/tag/tag-info';
import { AppService } from '@core/services/app.service';
import { NotificationService } from '@core/services/notification.service';
import { TagService } from '@core/services/tag.service';
import { forkJoin, takeUntil, tap } from 'rxjs';

@Component({
    templateUrl: './tag-applications-page.component.html',
    styleUrls: ['./tag-applications-page.component.sass']
})
export class TagApplicationsPageComponent extends BaseComponent implements OnInit {

    public loading = false;
    public apps: PaginatedList<App> | null;
    public pageSize: number = 10;
    public tagId: number | null = null;
    public tagInfo: TagInfo | null;

    countPluralMarring: { [k: string]: string } = { '=0': 'No apps.', '=1': 'one app', 'other': '# apps' };

    constructor(private route: ActivatedRoute,
        private appService: AppService,
        private tagService: TagService,
        private notificationService: NotificationService) {
        super();
    }

    ngOnInit(): void {

        this.route.params
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(() => {
                let tag = this.route.snapshot.params['id'];

                if (tag == "all") {
                    this.loadAllApps();
                    return;
                }

                this.tagId = tag;
                this.loadApps(1, this.tagId);

                this.tagService.getTagById(this.tagId!)
                    .pipe(takeUntil(this.unsubscribe$))
                    .subscribe({
                        next: (resp) => {
                            this.tagInfo = resp;
                        },
                        error: this.handleError
                    });
            });
    }

    loadAllApps() {
        this.tagInfo = {
            id: 0,
            name: "All apps",
            description: "Discover and share amazing repls to run, comment and fork",
            count: this.apps?.totalCount ?? 0
        }

        this.loadApps(1, null);
    }

    loadApps(pageNumber: number, tagId: number | null) {
        this.loading = true;

        let appsObservable = tagId !== null
            ? this.appService.getAppsWithTag(this.tagId!, pageNumber, this.pageSize)
            : this.appService.getAllApps(pageNumber, this.pageSize).pipe(tap(apps => this.tagInfo!.count = apps.totalCount ?? 0));

        appsObservable
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (resp) => {
                    this.loading = false;
                    this.apps = resp;
                },
                error: this.handleError
            });
    }

    handleError(error: any) {
        this.loading = false;
        this.notificationService.showErrorMessage(error.message, "Error")
    }
}
