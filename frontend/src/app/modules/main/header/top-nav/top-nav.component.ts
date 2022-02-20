import { Component, OnInit } from '@angular/core';
import { AuthService } from "@core/services/auth.service";
import { User } from "@core/models/user/user";
import { BaseComponent } from "@core/base/base.component";
import { takeUntil } from "rxjs";

@Component({
    selector: 'app-top-nav',
    templateUrl: './top-nav.component.html',
    styleUrls: ['./top-nav.component.sass'],
})
export class TopNavComponent extends BaseComponent implements OnInit {
    currentUser: User;
    constructor(
        private authService: AuthService
    ) {
        super();
    }

    ngOnInit(): void {
        this.authService
            .getCurrentUser()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((user) => this.currentUser = user);
    }

    logout() {
        this.authService.logOut();
    }
}
