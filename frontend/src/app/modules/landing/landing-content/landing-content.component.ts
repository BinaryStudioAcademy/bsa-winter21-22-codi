import { Component } from '@angular/core';
import {Languages} from "@shared/constants/languages";

@Component({
    selector: 'app-landing-content',
    templateUrl: './landing-content.component.html',
    styleUrls: ['./landing-content.component.sass'],
})
export class LandingContentComponent {

    IDEimage: string = 'assets/images/LandingPage/IDE.png';

    MultiplayerIMG: string = 'assets/images/LandingPage/multiplayer-cursors.png';

    CommunityIMG: string = 'assets/images/LandingPage/community.png';

    showMoreLanguages: boolean = false;

    languages = Languages;

    enumKeys: any = [];

    constructor() {
        this.enumKeys = Object.keys(this.languages).filter(f => !isNaN(Number(f)));
    }

    showMoreItems() {
        this.showMoreLanguages = !this.showMoreLanguages
    }
}
