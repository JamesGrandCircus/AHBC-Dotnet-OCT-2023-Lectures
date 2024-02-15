import { Component } from '@angular/core';
import { CounterService } from '../../services/counter.service';

@Component({
  selector: 'app-counter',
  standalone: true,
  imports: [],
  styles: `
:host {
  display: flex;
  gap: 0.5rem;
}

button {
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
  padding-left: 0.75rem;
  padding-right: 0.75rem;
  border: 1px solid black;
  border-radius: 0.5rem;
  background-color: #f0f0f0;
  cursor: pointer;
}
`,
  template: `
<button (click)="handleIncrement()">➕</button>
<button (click)="handleDecrement()">➖</button>
`,
})
export class CounterComponent {


  constructor(private counterService: CounterService) { }

  handleIncrement() {
    this.counterService.increment();
  }

  handleDecrement() {
    this.counterService.decrement();
  }
}
