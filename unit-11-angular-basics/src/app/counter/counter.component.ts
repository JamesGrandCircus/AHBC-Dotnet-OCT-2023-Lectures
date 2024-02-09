import { Component, EventEmitter, Input, Output } from '@angular/core';
import { ButtonComponent } from '../button/button.component';

@Component({
  // this is a css selector, the most common css
  // selector you will be using to reference this component,
  // is an element css selector, in other words, just the name
  // of your element
  selector: 'app-counter',
  standalone: true,
  imports: [
    ButtonComponent
  ],
  templateUrl: './counter.component.html',
  styleUrl: './counter.component.css'
})
export class CounterComponent {
  // add the @Input decorator to the value property
  // in order to make it PUBLIC to the PARENT COMPONENT!
  // this is basically like adding a "parameter" to a method
  @Input() value = 0;


  // output is how the Child component communicates with the Parent component
  @Output() valueChange = new EventEmitter<number>();

  increment() {
    this.value++;
    // firing off the event to the parent component!
    this.valueChange.emit(this.value);
  }

  decrement() {
    this.value--;
    this.valueChange.emit(this.value);
  }
}
