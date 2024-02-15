import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CounterComponent } from './components/counter/counter.component';
import { CounterDisplayComponent } from './components/counter-display/counter-display.component';
import { DogImageComponent } from './components/dog-image/dog-image.component';
import { HttpClientModule, provideHttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterOutlet,
    CounterComponent,
    CounterDisplayComponent,
    DogImageComponent,
  ],
  template: `
  <app-counter></app-counter>
  <app-counter-display></app-counter-display>
  <app-dog-image></app-dog-image>
`,
  styleUrl: './app.component.css'
})
export class AppComponent {

}
