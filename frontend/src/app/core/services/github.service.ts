import { Injectable } from '@angular/core';
import {HttpBackend, HttpClient, HttpHeaders} from "@angular/common/http";
import { environment } from "@env/environment";
import { AuthService } from "@core/services/auth.service";
import {Repository} from "@core/models/repository";

@Injectable({
  providedIn: 'root'
})
export class GithubService {
    private httpClient: HttpClient;
    private baseUrl = environment.githubAPI

    constructor(
        private handler: HttpBackend,
        private authService: AuthService
    ) {
        this.httpClient = new HttpClient(handler);
    }

    getHeaders(): HttpHeaders {
        return new HttpHeaders({Authorization: `Bearer ${this.authService.getGithubToken()}`});
    }

    getUserRepos() {
        return this.httpClient.get(`${this.baseUrl}/user/repos`, {
            headers: this.getHeaders()
        });
    }

    getRepoStructure() {
        https://api.github.com/repos/VynnykV/Archive/git/trees/master?recursive=1
    }

    isGithubTokenExists() {
        return !!this.authService.getGithubToken();
    }
}
