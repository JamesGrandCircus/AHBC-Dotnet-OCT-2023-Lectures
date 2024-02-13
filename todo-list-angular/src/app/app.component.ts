import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Todo } from './models/todo';
import { DecimalPipe, UpperCasePipe } from '@angular/common';
import { ButtonComponent } from './components/button/button.component';
import { TodoItemComponent } from './components/todo-item/todo-item.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, DecimalPipe, ButtonComponent, TodoItemComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  todos: Todo[] = [
    { task: 'Do the dishes', completed: false, duration: 15, priority: 'NORMAL' },
    { task: 'Take out the trash', completed: false, duration: 10, priority: 'HIGH' },
    { task: 'Walk the dog', completed: true, duration: 30, priority: 'LOW' }
  ]

  completeTask(index: number) {
    const todo = this.todos[index];
    todo.completed = true;
  }

  deleteTask(index: number) {
    // by passing in the index in this function, we can find ALL elements that DO NOT share 
    // that index, if that Index is IS shared, we ignore it! ie. we FILTER it OUT!
    this.todos = this.todos.filter((_todo, i) => i !== index);
  }
}
