import { Component, OnInit } from '@angular/core';
import { AuthService } from "@core/services/auth.service";
import { User } from "@core/models/user/user";
import { BaseComponent } from "@core/base/base.component";
import {switchMap, takeUntil} from "rxjs";
import { EventService } from "@core/services/event.service";
import {ProjectCreationModalService} from "@core/services/project-creation-modal.service";

@Component({
    selector: 'app-top-nav',
    templateUrl: './top-nav.component.html',
    styleUrls: ['./top-nav.component.sass'],
})
export class TopNavComponent extends BaseComponent implements OnInit {
    currentUser: User;
    constructor(
        private authService: AuthService,
        private eventService: EventService,
        private modalService: ProjectCreationModalService
    ) {
        super();
    }

    ngOnInit(): void {
        this.getUser();
        this.eventService.userChangedEvent$
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(() => this.getUser());
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
        this.authService.logOut();
    }

    createRepl() {
        this.modalService.openReplModal();
    }
}
