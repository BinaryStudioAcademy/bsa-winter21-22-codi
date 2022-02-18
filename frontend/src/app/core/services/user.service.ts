import { Injectable } from '@angular/core';
import { CodiHttpClientService } from "@core/services/codi-http-client.service";
import { User } from "@core/models/user/user";
import { UpdateUser } from "@core/models/user/update-user";

@Injectable({
  providedIn: 'root'
})
export class UserService {
  public routePrefix = '/api/users';

  constructor(
    private httpService: CodiHttpClientService
  ) { }

  public update(user: UpdateUser) {
    return this.httpService.putFullRequest(`${this.routePrefix}`, user);
  }

  public getById(id: number) {
    return this.httpService.getFullRequest<User>(`${this.routePrefix}/${id}`);
  }

  public getCurrent(email: string) {
    return this.httpService.getFullRequestWithHeader<User>(`${this.routePrefix}/email`, {
      email: email
    });
  }
}
