import { Injectable } from '@angular/core';
import { CodiHttpClientService } from "@core/services/codi-http-client.service";
import { AccessToken } from "@core/models/credentials/access-token";
import { AccessTokenCheck } from "@core/models/credentials/access-token-check";

@Injectable({
    providedIn: 'root'
})
export class CredentialsService {
    public routePrefix = '/credentials';

    constructor(private httpService: CodiHttpClientService) { }

    checkIfTokenValid(token: AccessToken) {
        return this.httpService.postRequest<AccessTokenCheck>(`${this.routePrefix}/token/valid`, token);
    }

    getUserAccessToken() {
        return this.httpService.getRequest<AccessToken>(`${this.routePrefix}/token`);
    }

    setUpUserToken(token: AccessToken){
        return this.httpService.postRequest<AccessToken>(`${this.routePrefix}/token`, token);
    }

    checkIfUserHasToken() {
        return this.httpService.getRequest<boolean>(`${this.routePrefix}/token/exist`);
    }
}
