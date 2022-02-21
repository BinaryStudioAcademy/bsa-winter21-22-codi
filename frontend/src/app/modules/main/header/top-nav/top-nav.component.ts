import { Component, OnInit } from '@angular/core';
import { AuthService } from '@core/services/auth.service';
import { Observable } from 'rxjs';
import { User } from 'firebase/auth';
import {ProjectCreationModalService} from "@core/services/project-creation-modal.service";

@Component({
    selector: 'app-top-nav',
    templateUrl: './top-nav.component.html',
    styleUrls: ['./top-nav.component.sass'],
})
export class TopNavComponent implements OnInit {
    constructor(private authService: AuthService, private modalService: ProjectCreationModalService) { }

    $currentUser: Observable<User | null>

    ngOnInit(): void {
        this.$currentUser = this.authService.currentUser$;
    }

    logout() {
        this.authService.logOut();
    }

    createRepl() {
        this.modalService.openReplModal();
    }
}
