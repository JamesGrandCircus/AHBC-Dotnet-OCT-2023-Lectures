import { Component, OnDestroy, OnInit } from '@angular/core';

@Component({
  selector: 'app-about-me',
  standalone: true,
  imports: [],
  templateUrl: './about-me.component.html',
  styleUrl: './about-me.component.css'
})
export class AboutMeComponent implements OnInit, OnDestroy {

  ngOnInit(): void {
    console.log("About me Created!");
  }

  ngOnDestroy(): void {
    console.log("About me Destroyed!");
  }
}
