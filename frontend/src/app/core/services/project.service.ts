import { Injectable } from '@angular/core';
import { CodiHttpClientService } from "@core/services/codi-http-client.service";
import { CreateProject } from "@core/models/project/create-project";
import { Project } from "@core/models/project/project";
import { ProjectName } from '@core/models/project/project-name';
import { GitClone } from "@core/models/git/git-clone";

@Injectable({
    providedIn: 'root'
})
export class ProjectService {

    public routePrefix = '/Projects';

    constructor(private httpService: CodiHttpClientService) { }

    getCurrentUserProjectNames() {
        return this.httpService.getRequest<ProjectName[]>(`${this.routePrefix}/my/names`)
    }

    getCurrentUserProjects() {
        return this.httpService.getRequest<Project[]>(`${this.routePrefix}/my`)
    }

    createProject(project: CreateProject) {
        return this.httpService.postRequest<Project>(`${this.routePrefix}`, project);
    }

    gitProjectImport(gitClone: GitClone) {
        return this.httpService.postRequest<Project>(`${this.routePrefix}/gitImport`, gitClone);
    }

    updateProject(project: Project) {
        return this.httpService.putRequest(`${this.routePrefix}`, project)
    }

    public deleteProject(id: number) {
        return this.httpService.deleteRequest(`${this.routePrefix}/${id}`);
    }
}
