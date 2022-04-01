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
import { ProjectService } from "@core/services/project.service";
import { ProjectSaverService } from "@core/services/project-saver.service";

@Component({
    selector: 'app-top-nav',
    templateUrl: './top-nav.component.html',
    styleUrls: ['./top-nav.component.sass', 'top-nav.compunent.style2.sass'],
})
export class TopNavComponent extends BaseComponent implements OnInit {
    userCanEdit: boolean = false;
    currentUser: User;
    form: FormGroup;
    constructor(
        private authService: AuthService,
        private eventService: EventService,
        public router: Router,
        private notificationService: NotificationService,
        private modalService: ProjectCreationModalService,
        private route: ActivatedRoute,
        private projectService: ProjectService,
        private projectSaverService: ProjectSaverService
    ) {
        super();
    }

    ngOnInit(): void {
        this.getUser();
        this.eventService.userChangedEvent$
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(() => this.getUser());

        if(this.router.url.includes('/workspace')) {
            this.form = new FormGroup({
                title: new FormControl('',
                    [
                        Validators.required,
                        Validators.minLength(2),
                        Validators.maxLength(60)
                    ])
            });

            this.getProjectInfo();

            this.form.valueChanges
                .pipe(takeUntil(this.unsubscribe$))
                .subscribe(() => {
                    this.projectSaverService.setProjectTitleIfChanged(this.form.value.title);
                })
        }
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

    saveChanges() {
        this.projectSaverService.saveChanges();
        this.notificationService.showSuccessMessage('Project changes saved', 'Success');
    }

    anyChangesSaved() {
        return !this.projectSaverService.isProjectChanged();
    }

    private setIsUserEditable() {
        this.projectService.isUserEditable(this.projectSaverService?.projectInfo.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((res) => {
                this.userCanEdit = res;
                if(!this.userCanEdit) {
                    this.form.controls['title'].disable();
                }
            });
    }

    private getUser() {
        this.authService
            .getCurrentUser()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((user) => {
                this.currentUser = user;
            })
    }

    private getProjectInfo() {
        let projectId = this.route.snapshot.params['id'];
        this.projectService
            .getProject(projectId)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((res) => {
                this.projectSaverService.projectInfo = res;
                this.setIsUserEditable();
                this.form.get('title')?.setValue(res.title);
            });
    }
}
