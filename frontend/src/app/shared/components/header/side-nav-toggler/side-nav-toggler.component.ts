import { Component } from '@angular/core';
import { SideNavService } from '@core/services/side-nav.service';

@Component({
    selector: 'app-side-nav-toggler',
    templateUrl: './side-nav-toggler.component.html',
    styleUrls: ['./side-nav-toggler.component.sass'],
})
export class SideNavTogglerComponent {
    constructor(public sideNavService: SideNavService) { }
}
