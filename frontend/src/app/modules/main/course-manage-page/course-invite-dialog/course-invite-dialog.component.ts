import {Component, Input, OnInit} from '@angular/core';
import {NgbActiveModal} from "@ng-bootstrap/ng-bootstrap";
import {UserService} from "@core/services/user.service";
import {debounceTime, distinctUntilChanged, map, Observable, of, OperatorFunction, switchMap, takeUntil, tap} from "rxjs";
import {catchError} from "rxjs/operators";
import {User} from "@core/models/user/user";
import {BaseComponent} from "@core/base/base.component";
import {Course} from "@core/models/course/course";
import {FormControl, FormGroup, Validators} from "@angular/forms";
import {CourseService} from "@core/services/course.service";
import {InviteUserCourse} from "@core/models/course/invite-user-course";
import {CourseUser} from "@core/models/course/course-user";
import {CourseRole} from "@core/models/course/course-role";
import {PaginatedList} from "@core/models/paginated-list/paginated-list";
import {DeleteUserCourse} from "@core/models/course/delete-user-course";
import {NotificationService} from "@core/services/notification.service";

@Component({
    templateUrl: './course-invite-dialog.component.html',
    styleUrls: ['./course-invite-dialog.component.sass']
})
export class CourseInviteDialogComponent extends BaseComponent implements OnInit {
    @Input() course: Course;
    courseUsers: PaginatedList<CourseUser> | null;
    searching = false;
    searchFailed = false;
    currentCourseUser = {} as CourseUser
    form: FormGroup;
    courseRole = CourseRole;
    pageSize: number = 5;

    constructor(
        public modal: NgbActiveModal,
        private userService: UserService,
        private courseService: CourseService,
        private notificationService: NotificationService
    )
    {
        super();
    }
    ngOnInit(): void {
        this.courseService
            .getCourseUser(this.course.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(cu => this.currentCourseUser = cu);

        this.reloadCourseUsers(1);

        this.form = new FormGroup({
            inviteUserName: new FormControl('',
                [
                    Validators.required
                ])
        })
    }

    inputFormatter = (user: {userName: string}) => user.userName;

    search: OperatorFunction<string, readonly User[]> = (text$: Observable<string>) =>
        text$.pipe(
            debounceTime(300),
            distinctUntilChanged(),
            tap(() => this.searching = true),
            switchMap(term =>
                this.searchUser(term).pipe(
                    tap(() => this.searchFailed = false),
                    catchError(() => {
                        this.searchFailed = true;
                        return of([]);
                    }))
            ),
            tap(() => this.searching = false)
        );

    searchUser(term: string) {
        if (term === '') {
            return of([]);
        }

        return this
            .userService
            .getByName(term)
            .pipe(
                map((response) => {
                    return response
                })
            );
    }

    reloadCourseUsers(pageNumber: number) {
        this.courseService
            .getCourseUsers(this.course.id, pageNumber, this.pageSize)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next:(courseUsers) => {
                    this.courseUsers = courseUsers;
                },
                error:() => this.notificationService.showErrorMessage('Something went wrong', "Error")
            });
    }

    inviteUser() {
        let invitedUser: CourseUser;
        let invitedUserId = this.form.value.inviteUserName.id;
        let inviteUserToCourse = {
            userId: invitedUserId,
            courseId: this.course.id
        } as InviteUserCourse;
        this.form.reset();
        this.courseService
            .inviteUserToCourse(inviteUserToCourse)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next:(resp) => {
                    invitedUser = resp
                    this.reloadCourseUsers( 1 )
                    this.notificationService
                        .showSuccessMessage('User invited from course', 'Success');
                },
                error:() => this.notificationService.showErrorMessage('User already invited form course', "Error")
            });
    }

    changeRole(id: number, role: CourseRole) {
        let changedUserRole: CourseUser;
        let changeCourseUserRole = {
            userId: id,
            courseId: this.course.id,
            courseRole: role.valueOf()
        } as InviteUserCourse
        this.courseService
            .changeCourseUserRole(changeCourseUserRole)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next:(resp) => {
                    changedUserRole = resp
                    this.reloadCourseUsers(1)
                    this.notificationService.showSuccessMessage('Permission changed', 'Success');
                },
                error:() =>  this.notificationService.showErrorMessage('Something went wrong', "Error")
            });
    }

    deleteUserCourse(id: number) {
        let deleteUser = {
            courseId: this.course.id,
            userId: id
        } as DeleteUserCourse
        this.courseService
            .deleteUserCourse(deleteUser)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next:() => {
                    this.reloadCourseUsers(1)
                    this.notificationService.showSuccessMessage('Remove user form the course', 'Success');
                },
                error:() =>  this.notificationService.showErrorMessage('Something went wrong', "Error")
            });
    }

}
