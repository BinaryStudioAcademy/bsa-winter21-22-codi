import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-landing-header',
  templateUrl: './landing-header.component.html',
  styleUrls: ['./landing-header.component.sass']
})
export class LandingHeaderComponent implements OnInit {

  landingImage:string = "assets/images/landinglogo.jpg";
  
  constructor() { }

  ngOnInit(): void {
  }
  scrollFunc(path:string){
    document.getElementById(path)?.scrollIntoView({behavior:'smooth', block: "start", inline: "nearest"});
  }
}
