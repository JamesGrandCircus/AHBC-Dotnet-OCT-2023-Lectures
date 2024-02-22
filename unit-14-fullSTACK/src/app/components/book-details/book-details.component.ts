import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { LibraryService } from '../../services/library.service';
import { Book } from '../../models/book';

@Component({
  selector: 'app-book-details',
  standalone: true,
  imports: [],
  templateUrl: './book-details.component.html',
  styleUrl: './book-details.component.css'
})
export class BookDetailsComponent implements OnInit {
  constructor(
    private activatedRoute: ActivatedRoute,
    private libraryService: LibraryService) { }

  paramsSubscription!: Subscription
  book: Book | null = null;


  // names.Select(name => name.ToUpper()).ToList();
  ngOnInit(): void {

    this.paramsSubscription = this.activatedRoute.params.subscribe(params => {

      const id = params['id'];

      this.libraryService.getBook(id).subscribe(book => {
        this.book = book;
      });

    })

  }
}
