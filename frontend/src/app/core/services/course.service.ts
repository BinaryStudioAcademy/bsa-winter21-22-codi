import { Injectable } from '@angular/core';
import { CodiHttpClientService } from "@core/services/codi-http-client.service";
import { CreateCourse } from "@core/models/course/create-course";
import { Course } from "@core/models/course/course";
import { UpdateCourse } from "@core/models/course/update-course";
import {InviteUserCourse} from "@core/models/course/invite-user-course";
import {CourseUser} from "@core/models/course/course-user";
import {PaginatedList} from "@core/models/paginated-list/paginated-list";
import {DeleteUserCourse} from "@core/models/course/delete-user-course";

@Injectable({
    providedIn: 'root'
})
export class CourseService {
    public routePrefix = '/courses';

    constructor(
        private httpService: CodiHttpClientService
    ) { }

    public create(course: CreateCourse) {
        return this.httpService.postRequest<Course>(`${this.routePrefix}`, course);
    }

    public update(course: UpdateCourse) {
        return this.httpService.putRequest<Course>(`${this.routePrefix}`, course);
    }

    public getCourse(name: string) {
        return this.httpService.getRequest<Course>(`${this.routePrefix}/findCourse/${name}`);
    }

    public delete(id: number) {
        return this.httpService.deleteRequest(`${this.routePrefix}/${id}`);
    }

    public leaveCourse(courseId: number) {
        return this.httpService.deleteRequest(`${this.routePrefix}/leaveCourse/${courseId}`);
    }

    public getCourseById(id: number) {
        return this.httpService.getRequest<Course>(`${this.routePrefix}/${id}`);
    }

    public inviteUserToCourse(courseUser: InviteUserCourse) {
        return this.httpService.postRequest<CourseUser>(`${this.routePrefix}/invite`, courseUser);
    }

    public getCourseUsers(courseId: number, pageNumber: number, pageSize: number) {
        return this.httpService
            .getRequest<PaginatedList<CourseUser>>(`${this.routePrefix}/courseUsers/${courseId}`,
            { pageNumber, pageSize });
    }

    public changeCourseUserRole(changeRole: InviteUserCourse) {
        return this.httpService.putRequest<CourseUser>(`${this.routePrefix}/changeRole`, changeRole);
    }

    public deleteUserCourse(deleteUserCourse: DeleteUserCourse) {
        return this.httpService.putRequest(`${this.routePrefix}/deleteUserCourse`, deleteUserCourse);
    }

    public getCourseUser(courseId: number) {
        return this.httpService.getRequest<CourseUser>(`${this.routePrefix}/courseUser/${courseId}`);
    }

    public getNameForValidator(name: string) {
        return this.httpService.getRequest<boolean>(`${this.routePrefix}/validator/${name}`);
    }

    public getCourseForCheckGuard(name: string) {
        return this.httpService.getRequest<boolean>(`${this.routePrefix}/guard/${name}`);
    }
}
