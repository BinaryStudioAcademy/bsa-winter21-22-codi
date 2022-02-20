import { Injectable } from '@angular/core';
import { CodiHttpClientService } from "@core/services/codi-http-client.service";
import { User } from "@core/models/user/user";
import { CreateUser } from "@core/models/user/create-user";

@Injectable({
  providedIn: 'root'
})
export class UserService {
  public routePrefix = '/api/users';

  constructor(
    private httpService: CodiHttpClientService
  ) { }

  public create(user: CreateUser) {
    return this.httpService.postFullRequest<User>(`${this.routePrefix}`, user);
  }

  public update(user: User) {
    return this.httpService.putFullRequest<User>(`${this.routePrefix}`, user);
  }

  public getById(id: number) {
    return this.httpService.getFullRequest<User>(`${this.routePrefix}/${id}`);
  }

  public getCurrent(email: string) {
    return this.httpService.getFullRequest<User>(`${this.routePrefix}/email`, {
      email: email
    });
  }
}
