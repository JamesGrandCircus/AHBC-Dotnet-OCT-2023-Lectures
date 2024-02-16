import { Routes } from '@angular/router';
import { AboutMeComponent } from './components/about-me/about-me.component';
import { ContactComponent } from './components/contact/contact.component';
import { BookComponent } from './components/book/book.component';

// this is where you define the Routes to your components where "mock" the idea of a different "page"
export const routes: Routes = [
	{ path: 'about-me', component: AboutMeComponent },
	{ path: 'contact', component: ContactComponent },

	// if you want to include a query parameters, they are NOT 
	// defined in your  path property in your route object. this is because
	// by nature, query parameters are USUALLY!!! optional. Route parameters
	// are REQUIRED, they are PART OF THE URL!!!
	{ path: 'book/:id', component: BookComponent },
];
