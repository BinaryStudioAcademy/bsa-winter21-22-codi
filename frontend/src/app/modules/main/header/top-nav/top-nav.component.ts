import { Component, OnInit } from '@angular/core';
import {AuthService} from "@core/services/auth.service";
import {Router} from "@angular/router";
import { Observable } from 'rxjs';
import { User } from 'firebase/auth';

@Component({
  selector: 'app-top-nav',
  templateUrl: './top-nav.component.html',
  styleUrls: ['./top-nav.component.sass']
})
export class TopNavComponent implements OnInit {

  constructor(private authService: AuthService) { }

  $currentUser: Observable<User | null>

  ngOnInit(): void {
    this.$currentUser = this.authService.currentUser$;
  }

  logout() {
    this.authService.logOut();
  }
}
