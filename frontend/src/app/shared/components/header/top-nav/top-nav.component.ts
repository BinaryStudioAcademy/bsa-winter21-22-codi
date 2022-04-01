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
import { BuildHubService } from '@core/hubs/build-hub.service';

@Component({
    selector: 'app-top-nav',
    templateUrl: './top-nav.component.html',
    styleUrls: ['./top-nav.component.sass', 'top-nav.compunent.style2.sass'],
})
export class TopNavComponent extends BaseComponent implements OnInit, OnDestroy {
    projectRunning: boolean = false;
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
        private buildHub: BuildHubService,
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
        }

        this.getProjectInfo();

        this.form.valueChanges
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(() => {
                this.projectSaverService.setProjectTitleIfChanged(this.form.value.title);
            })

        await this.buildHub.start();
        this.buildHub.listenMessages((output) => {
            this.notificationService.showInfoMessage(output.output, "Project #" + output.projectId.toString());
            this.projectRunning = false;
        });
    }

    override ngOnDestroy() {

        if (this.projectRunning) {
            this.projectService
                .stopProject(this.projectSaverService.projectInfo.id)
                .subscribe()
        }

        this.buildHub.stop();
        super.ngOnDestroy();
    }

    runProject() {
        this.projectRunning = true;
        this.projectService
            .runProject(this.projectSaverService.projectInfo.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(() => {
                this.notificationService.showSuccessMessage(undefined, "Project build started");
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

    saveChanges() {
        this.projectSaverService.saveChanges();
        this.notificationService.showSuccessMessage('Project changes saved', 'Success');
    }

    anyChangesSaved() {
        return !this.projectSaverService.isProjectChanged();
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
                this.form.get('title')?.setValue(res.title);
            });
    }
}
