import { Component } from '@angular/core';

@Component({
    selector: 'app-landing-content',
    templateUrl: './landing-content.component.html',
    styleUrls: ['./landing-content.component.sass'],
})
export class LandingContentComponent {

    IDEimage: string = 'assets/images/LandingPage/IDE.png';

    MultiplayerIMG: string = 'assets/images/LandingPage/multiplayer-cursors.png';

    CommunityIMG: string = 'assets/images/LandingPage/community.png';

    isReadMore: boolean = true;

    showText() {
        this.isReadMore = !this.isReadMore
    }
}
