import { Component } from '@angular/core';
import { Router, RouterModule, RouterOutlet } from '@angular/router';
import { AboutMeComponent } from './components/about-me/about-me.component';
import { ContactComponent } from './components/contact/contact.component';

@Component({
  selector: 'app-root',
  standalone: true,
  // if you want to use the routerLink attribute in your HTML, you need to import the RouterModule
  imports: [RouterOutlet, AboutMeComponent, RouterModule, ContactComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {

  constructor(private router: Router) {

  }

  routeToBook(id: number) {

    // you can write some logic BEFORE routing
    // the user to a specific route.

    // localhost:4200/book/1?name=John
    this.router.navigate(['book', id], { queryParams: { name: 'John' } });

    // the second argument for the navigate method is an object that allows you 
    // to pass in query parameters.
  }
}
