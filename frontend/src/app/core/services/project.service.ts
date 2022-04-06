import { Injectable } from '@angular/core';
import { CodiHttpClientService } from "@core/services/codi-http-client.service";
import { CreateProject } from "@core/models/project/create-project";
import { Project } from "@core/models/project/project";
import { ProjectName } from '@core/models/project/project-name';
import { GitClone } from "@core/models/git/git-clone";
import { ProjectWithLanguage } from "@core/models/project/project-with-language";
import { UpdateProject } from "@core/models/project/update-project";

@Injectable({
    providedIn: 'root'
})
export class ProjectService {

    public routePrefix = '/Projects';

    constructor(private httpService: CodiHttpClientService) { }

    getProject(projectId: number) {
        return this.httpService.getRequest<Project>(`${this.routePrefix}/${projectId}`);
    }

    getCurrentUserProjectNames() {
        return this.httpService.getRequest<ProjectName[]>(`${this.routePrefix}/my/names`)
    }

    getCurrentUserProjects() {
        return this.httpService.getRequest<Project[]>(`${this.routePrefix}/my`)
    }

    getCurrentUserGitProjects() {
        return this.httpService.getRequest<Project[]>(`${this.routePrefix}/mygit`)
    }

    createProject(project: CreateProject) {
        return this.httpService.postRequest<Project>(`${this.routePrefix}`, project);
    }

    isUserEditable(projectId: number) {
        return this.httpService.getRequest<boolean>(`${this.routePrefix}/isEditable/${projectId}`);
    }

    gitProjectImport(gitClone: GitClone) {
        return this.httpService.postRequest<Project>(`${this.routePrefix}/gitImport`, gitClone);
    }

    getCurrentUserLastProjects() {
        return this.httpService.getRequest<ProjectWithLanguage[]>(`${this.routePrefix}/my/last`);
    }

    getUsersProjectsById(userId: number) {
        return this.httpService.getRequest<ProjectWithLanguage[]>(`${this.routePrefix}/all/${userId}`);
    }

    updateProject(projectId: number, updateProject: UpdateProject) {
        return this.httpService.putRequest<Project>(`${this.routePrefix}/${projectId}`, updateProject);
    }

    deleteProject(id: number) {
        return this.httpService.deleteRequest(`${this.routePrefix}/${id}`);
    }

    runProject(id: number) {
        return this.httpService.postRequest(`${this.routePrefix}/${id}/run`, {});
    }

    stopProject(id: number) {
        return this.httpService.postRequest(`${this.routePrefix}/${id}/stop`, {});
    }

    inputProject(id: number, value: string) {
        return this.httpService.postRequest(`${this.routePrefix}/${id}/input?value=${value}`, {});
    }

    getCurrentUserGitLastProjects() {
        return this.httpService.getRequest<ProjectWithLanguage[]>(`${this.routePrefix}/my/gitlast`)
    }

    getCurrentUserMyProjects() {
        return this.httpService.getRequest<Project[]>(`${this.routePrefix}/myprojects`)
    }
}
