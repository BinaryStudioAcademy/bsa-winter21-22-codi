import { Component, OnInit } from '@angular/core';
import {AuthService} from "@core/services/auth.service";

@Component({
  selector: 'app-secret',
  templateUrl: './secret.component.html',
  styleUrls: ['./secret.component.sass']
})
export class SecretComponent implements OnInit {

  secrets: any;

  constructor(private authService: AuthService) { }

  ngOnInit(): void {
    this.authService.getUserSecrets().subscribe(secretData => {
      this.secrets = secretData
    });
  }

}
