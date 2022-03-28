import { Injectable } from '@angular/core';
import { CodiHttpClientService } from "@core/services/codi-http-client.service";
import { File } from "@core/models/file/file";

@Injectable({
    providedIn: 'root'
})
export class FileService {
    public routePrefix = '/files';

    constructor(private httpService: CodiHttpClientService) { }

    getFile(fileId: string) {
        return this.httpService.getRequest<File>(`${this.routePrefix}/${fileId}`);
    }
}
