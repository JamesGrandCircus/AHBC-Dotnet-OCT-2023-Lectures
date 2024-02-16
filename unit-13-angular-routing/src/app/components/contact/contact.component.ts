import { Component, OnDestroy, OnInit } from '@angular/core';

@Component({
  selector: 'app-contact',
  standalone: true,
  imports: [],
  templateUrl: './contact.component.html',
  styleUrl: './contact.component.css'
})
export class ContactComponent implements OnInit, OnDestroy {

  ngOnInit(): void {
    console.log('Contact Created!');
  }

  ngOnDestroy(): void {
    console.log("Contact Destroyed!");
  }

}
