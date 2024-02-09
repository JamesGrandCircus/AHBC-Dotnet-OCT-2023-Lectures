import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterOutlet } from '@angular/router';
import { Book } from './book';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterOutlet,
    // IN ORDER TO USE NGMODEL you HAVE TO IMPORT FormsModule
    // IN ORDER TO USE (ngSubmit) event, you HAVE TO IMPORT FormsModule
    FormsModule
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  // name will automatically be bound to the input with the [(ngModel)]="name"
  name: string = '';

  author: string = '';

  checkedOut: boolean = false;

  // defaults as an empty array!
  books: Book[] = [];

  handleSubmit() {
    const newBook: Book = {
      name: this.name,
      author: this.author,
      checkedOut: this.checkedOut
    };

    // the .push() method literally the same as the List.Add() method in C#
    this.books.push(newBook);
  }
}
