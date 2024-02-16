import { CommonModule } from '@angular/common';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, RouterModule } from '@angular/router';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-book',
  standalone: true,
  imports: [RouterModule, CommonModule],
  templateUrl: './book.component.html',
  styleUrl: './book.component.css'
})
export class BookComponent implements OnInit, OnDestroy {

  routeSubscription!: Subscription;
  querySubscription!: Subscription;
  id: number = 0;
  params$ = this.activatedRoute.params;
  queryParams$ = this.activatedRoute.queryParams;
  name: string | null = null

  // ActivatedRoute is a service that allows you to OBSERVE the route
  constructor(private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    // the subscribe method is used to OBSERVE the route
    // think of it like using the "await" keyword in C#
    // the subscribe method takes in a call back function (C# a lambda)
    // and that function will be called when your observable emits a new value
    // (or if you are thinking in terms of c#, once your awaitable is done)
    this.routeSubscription = this.activatedRoute.params.subscribe(params => {
      this.id = params['id'];
    })

    this.querySubscription = this.activatedRoute.queryParams.subscribe(queryParams => {
      if (queryParams['name']) {
        this.name = queryParams['name'];
      }
    })
  }

  ngOnDestroy(): void {
    // if you DO NOT unsubscribe from your observables, you will create
    // a memory leak in your application.
    this.routeSubscription.unsubscribe();
    this.querySubscription.unsubscribe();
  }
}
