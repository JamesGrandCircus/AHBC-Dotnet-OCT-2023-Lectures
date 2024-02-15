import { Injectable } from '@angular/core';

// the use case for THIS specific service is to maintain a "counter" value
// for multiple components!


// in angular, services are singletons by default, ALSO, they are added to our 
// so called Dependency Injection Container BY DEFAULT
@Injectable({
  providedIn: 'root' // this provided root means this service is available to the entire application
})
export class CounterService {
  counterValue = 0;

  increment() {
    this.counterValue++;
  }

  decrement() {
    this.counterValue--;
  }
}
