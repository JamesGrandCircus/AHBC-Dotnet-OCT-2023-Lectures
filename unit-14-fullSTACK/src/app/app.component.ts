import { Component } from '@angular/core';
import { RouterModule, RouterOutlet } from '@angular/router';
import { LibraryService } from './services/library.service';
import { CommonModule } from '@angular/common';
import { BooksTableComponent } from './components/books-table/books-table.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, CommonModule, BooksTableComponent, RouterModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent { }
