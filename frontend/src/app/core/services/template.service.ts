import { Injectable } from '@angular/core';
import {CodiHttpClientService} from "@core/services/codi-http-client.service";
import {Template} from "@core/models/template/template";

@Injectable({
    providedIn: 'root'
})
export class TemplateService {
    public routePrefix ='/Templates'

    constructor(private httpService: CodiHttpClientService) { }

    getNamesTemplate() {
        return this.httpService.getRequest<Template[]>(`${this.routePrefix}/names`)
    }
}
