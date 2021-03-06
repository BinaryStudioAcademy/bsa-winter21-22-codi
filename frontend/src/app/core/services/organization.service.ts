import { Injectable } from '@angular/core';
import { CodiHttpClientService } from "@core/services/codi-http-client.service";
import { CreateOrganization } from "@core/models/organization/create-organization";
import { Organization } from "@core/models/organization/organization";
import { UpdateOrganization } from "@core/models/organization/update-organization";

@Injectable({
    providedIn: 'root'
})
export class OrganizationService {
    public routePrefix = '/organizations';

    constructor(
        private httpService: CodiHttpClientService
    ) { }

    public create(organization: CreateOrganization) {
        return this.httpService.postRequest<Organization>(`${this.routePrefix}`, organization);
    }

    public update(organization: UpdateOrganization) {
        return this.httpService.putRequest<Organization>(`${this.routePrefix}`, organization);
    }

    public getUserOrganizations(userId: number) {
        return this.httpService.getRequest<Organization[]>(`${this.routePrefix}/user/${userId}`);
    }

    public delete(id: number) {
        return this.httpService.deleteRequest(`${this.routePrefix}/${id}`);
    }
}
