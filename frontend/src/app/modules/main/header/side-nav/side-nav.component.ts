import { Component } from '@angular/core';

import { SideNavService } from '@core/services/side-nav.service';

@Component({
    selector: 'app-side-nav',
    templateUrl: './side-nav.component.html',
    styleUrls: ['./side-nav.component.sass'],
})
export class SideNavComponent {
    constructor(public sideNavService: SideNavService) { }
}
