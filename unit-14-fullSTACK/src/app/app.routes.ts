import { Routes } from '@angular/router';
import { BooksTableComponent } from './components/books-table/books-table.component';
import { BookDetailsComponent } from './components/book-details/book-details.component';
import { BookFormComponent } from './components/add-book/book-form.component';

export const routes: Routes = [
	{
		path: 'books',
		component: BooksTableComponent
	},
	{
		// for route / path parameters, ":" tells angular
		// the parameter name, in this case, the parameter name
		// for the book route is "id"

		path: 'book/:id',
		component: BookDetailsComponent
	},

	{
		path: 'add-book',
		component: BookFormComponent
	},

	{
		path: 'update-book/:id',
		component: BookFormComponent
	}, 
];
