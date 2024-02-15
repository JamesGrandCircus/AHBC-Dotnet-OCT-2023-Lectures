import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { RandomDog } from '../models/random-dog';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DogImageService {

  constructor(private httpClient: HttpClient) { }

  private baseUrl = 'https://dog.ceo/api';


  // An observable is kind of SIMILAR to a C# Task, in that it 
  // is an async TYPE.
  // Observalble is an async type that the library rxjs uses, Angular UTILIZES Observables
  // pretty extensively.  Observables are a way to handle async operations and much more.  
  // the much more is a bit beyond the scope of this course, but it's a very powerful tool.
  getRandomDogImage(): Observable<RandomDog> {
    return this.httpClient.get<RandomDog>(`${this.baseUrl}/breeds/image/random`);
  }
}



@Injectable({
  providedIn: 'root'
})
export class LibraryService {

  constructor(private httpClient: HttpClient) { }

  private baseUrl = 'http://localhost:5178/api/library';


  // An observable is kind of SIMILAR to a C# Task, in that it 
  // is an async TYPE.
  // Observalble is an async type that the library rxjs uses, Angular UTILIZES Observables
  // pretty extensively.  Observables are a way to handle async operations and much more.  
  // the much more is a bit beyond the scope of this course, but it's a very powerful tool.
  getRandomDogImage() {
    return this.httpClient.get(this.baseUrl);
  }
}
