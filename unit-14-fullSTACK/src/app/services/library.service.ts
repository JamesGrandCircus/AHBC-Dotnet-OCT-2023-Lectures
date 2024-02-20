import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Book } from '../models/book';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: "root",
})
export class LibraryService { // the sole purpose of this service is to make http calls to YOUR controller in your 
  // dotnet api.

  constructor(private httpClient: HttpClient) { }

  baseUrl = `${environment.apiDomain}/api/Library`;

  getBooks() {
    // httpClient.get means this method will be making an http GET request!
    return this.httpClient.get<Book[]>(this.baseUrl)
  }

  getBook(id: number): Observable<Book> {
    return this.httpClient.get<Book>(`${this.baseUrl}/${id}`);
  }

}
