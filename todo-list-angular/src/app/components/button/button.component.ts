import { Component } from '@angular/core';

// you ONLY do this pattern for ALREADY existing HTML elements that you do not re-create,
// ie. buttons, input fields, etc.
// component selectors is how angular Determines which components to use in the application
@Component({
  selector: 'button[app-button]', // this selector is a CSS SELECTOR
  standalone: true,
  imports: [],
  templateUrl: './button.component.html',
  styleUrl: './button.component.css'
})
export class ButtonComponent {

}
