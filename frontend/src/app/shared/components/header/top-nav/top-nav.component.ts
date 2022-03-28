import { Component, OnInit } from '@angular/core';
import { AuthService } from "@core/services/auth.service";
import { User } from "@core/models/user/user";
import { BaseComponent } from "@core/base/base.component";
import { takeUntil} from "rxjs";
import { EventService } from "@core/services/event.service";
import { ProjectCreationModalService } from "@core/services/project-creation-modal.service";
import { ActivatedRoute, Router } from "@angular/router";
import { NotificationService } from "@core/services/notification.service";
import { FormControl, FormGroup, Validators } from "@angular/forms";
import { Project } from "@core/models/project/project";
import { ProjectService } from "@core/services/project.service";


@Component({
    selector: 'app-top-nav',
    templateUrl: './top-nav.component.html',
    styleUrls: ['./top-nav.component.sass', 'top-nav.compunent.style2.sass'],
})
export class TopNavComponent extends BaseComponent implements OnInit {
    currentUser: User;
    projectInfo: Project | undefined;
    form: FormGroup;
    constructor(
        private authService: AuthService,
        private eventService: EventService,
        public router: Router,
        private notificationService: NotificationService,
        private modalService: ProjectCreationModalService,
        private route: ActivatedRoute,
        private projectService: ProjectService
    ) {
        super();
    }

    ngOnInit(): void {
        this.getUser();
        this.eventService.userChangedEvent$
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(() => this.getUser());

        this.form = new FormGroup({
            title: new FormControl('',
                [
                    Validators.required,
                    Validators.minLength(2)
                ])
        });

        this.getProjectInfo();
    }

    getProjectInfo() {
        if(this.router.url.includes('/workspace')) {
            let projectId = this.route.snapshot.params['id'];
            this.projectService
                .getProject(projectId)
                .pipe(takeUntil(this.unsubscribe$))
                .subscribe((res) => {
                    this.projectInfo = res;
                    this.form.get('title')?.setValue(res.title);
                })
        }
    }

    getUser() {
        this.authService
            .getCurrentUser()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((user) => {
                this.currentUser = user;
            })
    }

    logout() {
        this.authService.logOut()
            .then(() => {
                this.router.navigate(['login']).then(() => {
                    this.notificationService.showSuccessMessage('Good Luck!');
                });
            });
    }

    createProject() {
        this.modalService.openCreateDialog();
    }
}
