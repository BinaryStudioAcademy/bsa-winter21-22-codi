import { Injectable } from '@angular/core';
import {CodiHttpClientService} from "@core/services/codi-http-client.service";
import {CreateProject} from "@core/models/project/create-project";
import {Project} from "@core/models/project/project";

@Injectable({
    providedIn: 'root'
})
export class ProjectService {

    public routePrefix = '/Projects';

    constructor(private httpService: CodiHttpClientService) { }

    public createProject(project: CreateProject) {
        return this.httpService.postRequest<Project>(`${this.routePrefix}`, project);
    }

    public updateProject(project: Project) {
        return this.httpService.putRequest(`${this.routePrefix}`, project)
    }
}
