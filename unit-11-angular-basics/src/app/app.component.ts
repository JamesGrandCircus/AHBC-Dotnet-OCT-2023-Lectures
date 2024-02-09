import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CounterComponent } from './counter/counter.component';
import { NameListComponent } from './name-list/name-list.component';
import { ButtonComponent } from './button/button.component';
import { CardComponent } from './card/card.component';

// Component Decorator, this tells Angular that this class is a component
// the component decorator takes a configuration object with the following properties
@Component({
  // this is the components css / html selector, this is how angular knows how to reference it in the "template" or "html"
  selector: 'app-root',

  // standalone means this component does NOT need to live in a module, it can be used anywhere
  standalone: true,

  // this is where we setup our Dependency Injection, we are telling Angular that we want to use the RouterOutlet
  imports: [
    RouterOutlet,
    NameListComponent,
    CounterComponent,
    ButtonComponent,
    CardComponent
  ],

  // this is the path to the components html file
  templateUrl: './app.component.html',

  // this is the path to the components css file
  styleUrl: './app.component.css'
})
export class AppComponent {

  // this is a class property, it acts as STATE for your component.
  // you can think of this as the "model" for your component
  // state is literally the "State" of you component, ie, what does the data
  // look like specifically for this component
  // your members HAVE TO BE PUBLIC in order for the template to access them!
  title = 'unit-11-angular-basics';
  value = 0;
  latestChildCounterValue = 0;
  beatles = ['John', 'Paul', 'George', 'Ringo'];
  students = ['Peggy', 'Frank', 'Nathaniel', 'Lauren', 'David', 'Aimee', 'Benjamin', 'Angela'];

  // in javascript/typescript, FIELDS are PUBLIC!!!! by DEFAULT!

  // in C#, members are PRIVATE by default.!!!


  increment() {
    this.value++;
  }

  decrement() {
    this.value--;
  }
  // any data / members you want to render in the html file
  // HAS to live in the class itself

  handleValueChange(value: number) {
    this.latestChildCounterValue = value;
  }
}

// by convention, the app.component is the ENTRY POINT COMPONENT for the rest of your application!
// given that we are working in a component based architecture, this is the first component that will be loaded
