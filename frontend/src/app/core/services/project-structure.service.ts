import { Injectable } from '@angular/core';
import { CodiHttpClientService } from "@core/services/codi-http-client.service";
import { ProjectStructure } from "@core/models/structure/project-structure";

@Injectable({
    providedIn: 'root'
})
export class ProjectStructureService {
    public routePrefix = '/projectStructure';

    constructor(private httpService: CodiHttpClientService) { }

    getProjectStructure(projectId: number) {
        return this.httpService.getRequest<ProjectStructure>(`${this.routePrefix}/${projectId}`);
    }
}
