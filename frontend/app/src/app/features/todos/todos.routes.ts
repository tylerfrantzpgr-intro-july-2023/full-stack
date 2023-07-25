import { Routes } from '@angular/router';
import { TodosComponent } from './todos.component';
import { FEATURE_NAME, reducers } from '../counter/state';
import { provideState } from '@ngrx/store';
import { provideHttpClient } from '@angular/common/http';

export const todosRoutes: Routes = [{ path: '', component: TodosComponent, providers: [
    provideState(FEATURE_NAME, reducers)
] }];
