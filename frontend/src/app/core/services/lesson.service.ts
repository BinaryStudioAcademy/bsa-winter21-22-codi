import { Injectable } from '@angular/core';
import { CodiHttpClientService } from "@core/services/codi-http-client.service";
import { CreateLesson } from "@core/models/lesson/create-lesson";
import { Lesson } from "@core/models/lesson/lesson";
import { PublishLesson } from "@core/models/lesson/publish-lesson";
import { LessonToUnit } from "@core/models/lesson/lesson-to-unit";

@Injectable({
    providedIn: 'root'
})
export class LessonService {
    public routePrefix = '/lessons';

    constructor(
        private httpService: CodiHttpClientService
    ) { }

    create(lesson: CreateLesson) {
        return this.httpService.postRequest<Lesson>(`${this.routePrefix}`, lesson);
    }

    getCourseLessonsWithoutUnit(courseId: number) {
        return this.httpService.getRequest<Lesson[]>(`${this.routePrefix}/noUnit/${courseId}`);
    }

    getPublishedCourseLessons(courseId: number) {
        return this.httpService.getRequest<Lesson[]>(`${this.routePrefix}/published/${courseId}`);
    }

    publishLesson(lessonId: number, publish: PublishLesson) {
        return this.httpService.patchRequest(`${this.routePrefix}/publish/${lessonId}`, publish);
    }

    lessonToUnit(lessonToUnit: LessonToUnit) {
        return this.httpService.patchRequest(`${this.routePrefix}/lessonToUnit`, lessonToUnit);
    }

    delete(lessonId: number) {
        return this.httpService.deleteRequest(`${this.routePrefix}/${lessonId}`);
    }
}
