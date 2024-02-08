import { Component } from '@angular/core';

@Component({
  selector: 'button[app-button]', // THIS IS A CSS SELECTOR!!!!
  // this selects ANY button that has an attribute names app-button
  standalone: true,
  imports: [],
  templateUrl: './button.component.html',
  styleUrl: './button.component.css'
})
export class ButtonComponent { }
