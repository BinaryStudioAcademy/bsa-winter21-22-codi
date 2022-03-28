import { Injectable } from '@angular/core';
import {ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree} from '@angular/router';
import {Observable} from 'rxjs';
import {CourseService} from "@core/services/course.service";
import {map} from "rxjs/operators";

@Injectable({
    providedIn: 'root'
})
export class CourseGuard implements CanActivate {

    constructor(private courseService: CourseService, private router: Router) {}

    canActivate(
        route: ActivatedRouteSnapshot,
        state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
        const notFound: UrlTree = this.router.createUrlTree(['**'])
        const courseUserName = route.paramMap.get('name');
        return this.courseService.getCourseForCheckGuard(courseUserName!)
            .pipe(map((response) => {
                return response ? response : notFound
            }));
    }

}
