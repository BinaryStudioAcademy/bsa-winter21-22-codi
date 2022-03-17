import { Component, Input, OnInit } from '@angular/core';
import { App } from '@core/models/app/app';

@Component({
    selector: 'app-card',
    templateUrl: './app-card.component.html',
    styleUrls: ['./app-card.component.sass']
})
export class AppCardComponent {

    @Input() public app: App;

    constructor() {}
}
