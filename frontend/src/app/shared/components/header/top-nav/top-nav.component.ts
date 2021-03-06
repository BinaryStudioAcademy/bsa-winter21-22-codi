import { Component, OnDestroy, OnInit } from '@angular/core';
import { AuthService } from "@core/services/auth.service";
import { User } from "@core/models/user/user";
import { BaseComponent } from "@core/base/base.component";
import { takeUntil } from "rxjs";
import { EventService } from "@core/services/event.service";
import { ProjectCreationModalService } from "@core/services/project-creation-modal.service";
import { ActivatedRoute, Router } from "@angular/router";
import { NotificationService } from "@core/services/notification.service";
import { FormControl, FormGroup, Validators } from "@angular/forms";
import { ProjectService } from "@core/services/project.service";
import { ProjectSaverService } from "@core/services/project-saver.service";
import { ConsoleService } from '@core/services/console.service';
@Component({
    selector: 'app-top-nav',
    templateUrl: './top-nav.component.html',
    styleUrls: ['./top-nav.component.sass', 'top-nav.component.style2.sass'],
})
export class TopNavComponent extends BaseComponent implements OnInit, OnDestroy {
    projectBuilding: boolean = false;
    projectRunning: boolean = false;
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
        private projectSaverService: ProjectSaverService,
        private consoleService: ConsoleService
    ) {
        super();
    }

    async ngOnInit() {
        this.getUser();
        this.eventService.userChangedEvent$
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(() => this.getUser());

        if (this.router.url.includes('/workspace')) {
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

        this.consoleService.receivedOutput$.subscribe(() => {
            this.projectBuilding = false;
            this.projectRunning = true;
        })
    }

    runProject() {
        this.projectBuilding = true;
        this.consoleService.startProject();
    }

    stopContainer(){
        this.projectRunning = false;
        this.consoleService.stopContainer();
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
        this.notificationService.showSuccessMessage(undefined, 'Project changes saved');
    }

    toggleConsole() {
        this.consoleService.toggleConsole();
    }

    anyChangesSaved() {
        return !this.projectSaverService.isProjectChanged();
    }

    private setIsUserEditable() {
        this.projectService.isUserEditable(this.projectSaverService?.projectInfo.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((res) => {
                this.userCanEdit = res;
                if (!this.userCanEdit) {
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
