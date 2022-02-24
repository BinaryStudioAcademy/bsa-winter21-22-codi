import { Injectable } from '@angular/core';
import { CodiHttpClientService } from "@core/services/codi-http-client.service";
import { CreateCourse } from "@core/models/course/create-course";
import { Course } from "@core/models/course/course";
import { UpdateCourse } from "@core/models/course/update-course";

@Injectable({
  providedIn: 'root'
})
export class CourseService {
    public routePrefix = '/courses';

    constructor(
        private httpService: CodiHttpClientService
    ) { }

    public create(course: CreateCourse) {
        return this.httpService.postFullRequest<Course>(`${this.routePrefix}`, course);
    }

    public update(course: UpdateCourse) {
        return this.httpService.putFullRequest<Course>(`${this.routePrefix}`, course);
    }

    public getCourse(name: string) {
        return this.httpService.getFullRequest<Course>(`${this.routePrefix}/${name}`);
    }

    public delete(id: number) {
        return this.httpService.deleteFullRequest(`${this.routePrefix}/${id}`);
    }
}
