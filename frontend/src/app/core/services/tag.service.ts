import { Injectable } from '@angular/core';
import { CodiHttpClientService } from "@core/services/codi-http-client.service";
import { App } from '@core/models/app/app';
import { PaginatedList } from '@core/models/paginated-list/paginated-list';
import { TagInfo } from '@core/models/tag/tag-info';
import { TagName } from '@core/models/tag/tag-name';

@Injectable({
    providedIn: 'root'
})
export class TagService {
    public routePrefix = '/tags'

    constructor(private httpService: CodiHttpClientService) {}

    getAllTags() {
        return this.httpService.getRequest<TagName[]>(`${this.routePrefix}`)
    }

    getTagById(tagId: number) {
        return this.httpService.getRequest<TagInfo>(`${this.routePrefix}/${tagId}`)
    }
}
