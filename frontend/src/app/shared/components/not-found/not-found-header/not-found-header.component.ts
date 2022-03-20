import { Component } from '@angular/core';
import {Router} from "@angular/router";

@Component({
    selector: 'app-not-found-header',
    templateUrl: './not-found-header.component.html',
    styleUrls: ['./not-found-header.component.sass']
})
export class NotFoundHeaderComponent {

    constructor(
        public router: Router,
    ) {}

    

}
