import { Component, EventEmitter, Output } from '@angular/core';
import { LibraryService } from '../../services/library.service';
import { CommonModule } from '@angular/common';
import { Router, RouterModule } from '@angular/router';
import { Book } from '../../models/book';

@Component({
  selector: 'app-books-table',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './books-table.component.html',
  styleUrl: './books-table.component.css'
})
export class BooksTableComponent {
  constructor(
    private libraryService: LibraryService,
    private router: Router) { }

  books$ = this.libraryService.getBooks();

  routeToBook(id: number) {
    this.router.navigate(['book', id]);
  }
}
