import { Component } from '@angular/core';
import { CounterService } from '../../services/counter.service';

@Component({
  selector: 'app-counter-display',
  standalone: true,
  imports: [],
  template: `
  <h1>Counter Display!</h1>
  <h2>Counter Value: {{counterValue}}</h2>
`,
  styles: `
  :host {
    display: flex;
    flex-direction: column;
    justify-content: center;
    gap: 0.5rem;
  }
`
})
export class CounterDisplayComponent {
  constructor(private counterService: CounterService) { }

  // this is a Getter Method in typescript, C# ALSO has 
  // GETTERS and SETTERS, in typescript, they just look more like
  // functions!
  get counterValue() {
    return this.counterService.counterValue;
  }
}
