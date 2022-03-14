import { Injectable } from '@angular/core';
import { CodiHttpClientService } from "@core/services/codi-http-client.service";
import { User } from "@core/models/user/user";
import { CreateUser } from "@core/models/user/create-user";

@Injectable({
    providedIn: 'root'
})
export class UserService {
    public routePrefix = '/users';

    constructor(
        private httpService: CodiHttpClientService
    ) { }

    public create(user: CreateUser) {
        return this.httpService.postRequest<User>(`${this.routePrefix}`, user);
    }

    public update(user: User) {
        return this.httpService.putRequest<User>(`${this.routePrefix}`, user);
    }

    public getById(id: number) {
        return this.httpService.getRequest<User>(`${this.routePrefix}/${id}`);
    }

    public getCurrent(firebaseId: string) {
        return this.httpService.getRequest<User>(`${this.routePrefix}/firebaseId`, {
            id: firebaseId
        });
    }
}
