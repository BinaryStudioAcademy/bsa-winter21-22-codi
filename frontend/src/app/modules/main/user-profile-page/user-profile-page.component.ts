import { Component, OnInit } from '@angular/core';
import { NgbCarouselConfig } from "@ng-bootstrap/ng-bootstrap";
import { UserService } from "@core/services/user.service";
import { BaseComponent } from "@core/base/base.component";
import { ActivatedRoute } from "@angular/router";
import {switchMap, take, takeUntil} from "rxjs";
import { User } from "@core/models/user/user";
import { AuthService } from "@core/services/auth.service";

@Component({
  selector: 'app-user-profile-page',
  templateUrl: './user-profile-page.component.html',
  styleUrls: ['./user-profile-page.component.sass'],
  providers: [NgbCarouselConfig]
})
export class UserProfilePageComponent extends BaseComponent implements OnInit {

  public user = {} as User;
  public id: number;

  constructor(
    config: NgbCarouselConfig,
    private route: ActivatedRoute,
    private userService: UserService,
    private authService: AuthService
  ) {
    super();
    config.showNavigationArrows = false;
    config.interval = 0;
  }

  ngOnInit(): void {
    this.id = this.route.snapshot.params['id'];
    if(this.id !== undefined) {
      this.userService
        .getById(this.id)
        .pipe(takeUntil(this.unsubscribe$))
        .subscribe((user) => this.user = user.body!);
    }
    else {
      this.authService
        .getCurrentUser()
        .pipe(takeUntil(this.unsubscribe$))
        .subscribe((user) => this.user = user);
    }
  }
}

