import { Injectable } from '@angular/core';
import { CodiHttpClientService } from "@core/services/codi-http-client.service";
import { App } from '@core/models/app/app';
import { PaginatedList } from '@core/models/paginated-list/paginated-list';
import { CreateApp } from '@core/models/app/create-app';

@Injectable({
    providedIn: 'root'
})
export class AppService {
    public routePrefix = '/apps'

    constructor(private httpService: CodiHttpClientService) {}

    getAllApps(pageNumber: number, pageSize: number) {
        return this.httpService.getRequest<PaginatedList<App>>(`${this.routePrefix}`, { pageNumber, pageSize })
    }

    getAppsWithTag(tagId: number, pageNumber: number, pageSize: number) {
        return this.httpService.getRequest<PaginatedList<App>>(`${this.routePrefix}/withTag/${tagId}`, { pageNumber, pageSize })
    }

    createApp(app: CreateApp) {
        return this.httpService.postRequest<App>(`${this.routePrefix}`, app);
    }
}
