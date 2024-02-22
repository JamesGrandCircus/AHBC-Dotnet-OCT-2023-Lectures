import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { LibraryService } from '../../services/library.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-book-form',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './book-form.component.html',
  styleUrl: './book-form.component.css'
})
export class BookFormComponent implements OnInit {
  constructor(
    private libraryService: LibraryService,
    private router: Router,
    private activatedRoute: ActivatedRoute
  ) { }

  id: null | number = null;

  title: string = '';
  author: string = '';
  pages: number = 0;
  checkedOut: boolean = false;

  ngOnInit(): void {
    this.activatedRoute.params.subscribe((params) => {
      // in case this component is being used to update a book instead
      if (params['id']) {
        this.id = params['id'];

        this.activatedRoute.queryParams.subscribe((queryParams) => {
          this.title = queryParams['title'];
          this.author = queryParams['author'];
          this.pages = +queryParams['pages'];
          this.checkedOut = queryParams['checkedOut'] === 'true';
        })
      }
    })
  }

  handleBookSubmission() {
    if (this.id) {
      this.updateBook();
    } else {
      this.addBook();
    }
  }

  updateBook() {
    const updatedBook = {
      id: this.id!,
      title: this.title,
      author: this.author,
      checkedOut: this.checkedOut,
      pages: this.pages
    }


    this.libraryService.updateBook(updatedBook, this.id!).subscribe(() => {
      this.router.navigate(['books']);
    })
  }

  addBook() {

    const newBook = {
      title: this.title,
      author: this.author,
      checkedOut: this.checkedOut,
      pages: this.pages
    };

    this.libraryService.postBook(newBook).subscribe(() => {
      this.router.navigate(['books']);
    });
  }

}
