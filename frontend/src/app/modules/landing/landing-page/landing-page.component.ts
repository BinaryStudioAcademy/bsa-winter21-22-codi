import { Component, OnInit } from '@angular/core';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
  selector: 'app-landing-page',
  templateUrl: './landing-page.component.html',
  styleUrls: ['./landing-page.component.sass']
})
export class LandingPageComponent implements OnInit {

  constructor(private spinnerService: SpinnerService) { }

  ngOnInit(): void {
  }
}