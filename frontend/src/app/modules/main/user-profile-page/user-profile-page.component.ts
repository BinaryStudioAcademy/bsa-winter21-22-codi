import { Component, OnInit } from '@angular/core';
import { NgbCarouselConfig } from "@ng-bootstrap/ng-bootstrap";

@Component({
  selector: 'app-user-profile-page',
  templateUrl: './user-profile-page.component.html',
  styleUrls: ['./user-profile-page.component.sass'],
  providers: [NgbCarouselConfig]
})
export class UserProfilePageComponent implements OnInit {

  constructor(config: NgbCarouselConfig) {
    config.showNavigationArrows = false;
    config.interval = 0;
  }

  ngOnInit(): void {
  }

  changeRepl(event: any) {

  }

}
