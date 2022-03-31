import { Injectable } from '@angular/core';
import { CodiHttpClientService } from "@core/services/codi-http-client.service";
import { File } from "@core/models/file/file";
import { UpdateFile } from "@core/models/file/update-file";
import { forkJoin, Observable } from "rxjs";

@Injectable({
    providedIn: 'root'
})
export class FileService {
    public routePrefix = '/files';

    constructor(private httpService: CodiHttpClientService) { }

    getFile(fileId: string) {
        return this.httpService.getRequest<File>(`${this.routePrefix}/${fileId}`);
    }

    updateFile(file: UpdateFile) {
        return this.httpService.putRequest<File>(`${this.routePrefix}`, file);
    }

    updateFiles(files: UpdateFile[]): Observable<File[]> {
        return forkJoin(files.map(file => this.updateFile(file)));
    }
}
