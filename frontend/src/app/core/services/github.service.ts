import { Injectable } from '@angular/core';
import { CodiHttpClientService } from "@core/services/codi-http-client.service";
import { GithubUser } from "@core/models/github/github-user";
import { GithubRepository } from "@core/models/github/github-repository";
import { GithubRepositoryLink } from "@core/models/github/github-repository-link";

@Injectable({
    providedIn: 'root'
})
export class GithubService {
    public routePrefix = '/github';

    constructor(private httpService: CodiHttpClientService) { }

    getUser() {
        return this.httpService.getRequest<GithubUser>(`${this.routePrefix}/user`);
    }

    getUserRepositories() {
        return this.httpService.getRequest<GithubRepository[]>(`${this.routePrefix}/user/repositories`);
    }

    isRepositoryAccessible(link: GithubRepositoryLink) {
        return this.httpService.postRequest<boolean>(`${this.routePrefix}/repo/exist`, link);
    }
}
