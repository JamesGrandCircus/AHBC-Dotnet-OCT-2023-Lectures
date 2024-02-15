import { ApplicationConfig } from '@angular/core';
import { provideRouter } from '@angular/router';

import { routes } from './app.routes';
import { provideHttpClient } from '@angular/common/http';

export const appConfig: ApplicationConfig = {
  providers: [
    provideRouter(routes),
    // think of this as dependency injection
    // for the DEPENDENCIES of your SERVICES
    // IF those dependencies are provided by Angular
    provideHttpClient()
  ]
};
