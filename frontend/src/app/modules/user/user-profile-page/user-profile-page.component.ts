import { Component, OnInit } from '@angular/core';
import { UserService } from "@core/services/user.service";
import { BaseComponent } from "@core/base/base.component";
import { ActivatedRoute, Router } from "@angular/router";
import { takeUntil } from "rxjs";
import { User } from "@core/models/user/user";
import { AuthService } from "@core/services/auth.service";
import { ProjectService } from "@core/services/project.service";
import { ProjectWithLanguage } from "@core/models/project/project-with-language";
import { NotificationService } from "@core/services/notification.service";
import { IconLanguageHelper } from "@shared/helpers/icon-language-helper";
import { Language } from "@core/enums/language";

@Component({
    selector: 'app-user-profile-page',
    templateUrl: './user-profile-page.component.html',
    styleUrls: ['./user-profile-page.component.sass'],
})
export class UserProfilePageComponent extends BaseComponent implements OnInit {

    public currentUser = {} as User;
    public user = {} as User;
    public id: number;
    projects: ProjectWithLanguage[] = [];
    loading: boolean = false;

    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private userService: UserService,
        private authService: AuthService,
        private projectService: ProjectService,
        private notificationService: NotificationService
    ) {
        super();
    }

    ngOnInit(): void {
        this.loading = true;
        this.authService
            .getCurrentUser()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((user) => this.currentUser = user);

        this.route.params.pipe(
            takeUntil(this.unsubscribe$)
        ).subscribe(() => {
            this.id = this.route.snapshot.params['id'];
            this.getUser();
            this.getUserProjects();
        });

    }

    getUser() {
        this.userService
            .getById(this.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                (user) => {
                    this.user = user
                },
                error => {
                    this.router.navigate(['not-found']);
                }
            );
    }

    getUserProjects() {
        this.projectService.getUsersProjectsById(this.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next:(projects) => {
                    this.loading = false;
                    this.projects = projects;
                },
                error:() =>
                    this.notificationService.showErrorMessage('Something went wrong', 'Error')
            });
    }

    iconForLanguage(extension: number)  {
        return IconLanguageHelper(extension);
    }

    forEnum(index: number) {
        return Object.values(Language)[index];
    }

}


