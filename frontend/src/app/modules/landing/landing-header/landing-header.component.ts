import { Component } from '@angular/core';

@Component({
    selector: 'app-landing-header',
    templateUrl: './landing-header.component.html',
    styleUrls: ['./landing-header.component.sass'],
})
export class LandingHeaderComponent {
  landingImage: string = 'assets/images/LandingPage/Logo.svg';

  scrollFunc(path: string) {
    document.getElementById(path)?.scrollIntoView({ behavior: 'smooth', block: 'start', inline: 'nearest' });
  }
}
