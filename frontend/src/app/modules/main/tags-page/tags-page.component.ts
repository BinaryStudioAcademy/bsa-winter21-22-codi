import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { TagName } from '@core/models/tag/tag-name';
import { NotificationService } from '@core/services/notification.service';
import { TagService } from '@core/services/tag.service';
import { takeUntil } from 'rxjs';

@Component({
    templateUrl: './tags-page.component.html',
    styleUrls: ['./tags-page.component.sass']
})
export class TagsPageComponent extends BaseComponent implements OnInit {

    public loading = false;
    public tags: TagName[];

    constructor(private tagService: TagService,
        private notificationService: NotificationService) {
        super();
    }

    ngOnInit(): void {
        this.tagService
            .getAllTags()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (resp) => {
                    this.loading = false;
                    this.tags = resp ?? [];
                },
                error: (error) => {
                    this.loading = false;
                    this.notificationService.showErrorMessage(error.message, "Error")
                }

            })
    }

}
