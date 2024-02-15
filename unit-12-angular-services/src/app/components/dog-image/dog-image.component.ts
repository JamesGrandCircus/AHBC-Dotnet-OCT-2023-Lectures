import { Component } from '@angular/core';
import { DogImageService } from '../../services/dog-image.service';
import { Observable } from 'rxjs';
import { RandomDog } from '../../models/random-dog';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-dog-image',
  standalone: true,
  imports: [CommonModule, HttpClientModule],

  // your html will "handle" your async types, ie. it will get the 
  // RandomDog object OUT of the Observable FOR YOU!
  template: `
  @if (dogImage$ | async; as dogImage) {
    <img [src]="dogImage.message" />
  } @else {
    <div></div>
  }
`,
  styles: `
  img {
    width: 8rem;
    height: 8rem;
    border-radius: 9999px;
  }

  div {
    width: 8rem;
    height: 8rem;
    border-radius: 9999px;
    background-color: gray;
  }
`
})
export class DogImageComponent {

  // The dogImageService is injected into the constructor, Dependancy Injection
  constructor(private dogImageService: DogImageService) { }

  // by convention, observables end with a $, so dogImage$ is an observable
  dogImage$ = this.dogImageService.getRandomDogImage();
}
