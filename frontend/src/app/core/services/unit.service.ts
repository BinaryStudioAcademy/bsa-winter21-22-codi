import { Injectable } from '@angular/core';
import {CodiHttpClientService} from "@core/services/codi-http-client.service";
import {CreateUnit} from "@core/models/unit/create-unit";
import {Unit} from "@core/models/unit/unit";
import {UpdateUnit} from "@core/models/unit/update-unit";

@Injectable({
    providedIn: 'root'
})
export class UnitService {
    public routePrefix = '/units';

    constructor(
        private httpService: CodiHttpClientService
    ) { }

    create(unit: CreateUnit) {
        return this.httpService.postRequest<Unit>(`${this.routePrefix}`, unit);
    }

    getCourseUnits(courseId: number) {
        return this.httpService.getRequest<Unit[]>(`${this.routePrefix}/${courseId}`);
    }

    getCoursePublishedUnits(courseId: number) {
        return this.httpService.getRequest<Unit[]>(`${this.routePrefix}/published/${courseId}`);
    }

    update(unit: UpdateUnit) {
        return this.httpService.putRequest<Unit>(`${this.routePrefix}`, unit);
    }

    delete(unitId: number) {
        return this.httpService.deleteRequest(`${this.routePrefix}/${unitId}`);
    }
}
