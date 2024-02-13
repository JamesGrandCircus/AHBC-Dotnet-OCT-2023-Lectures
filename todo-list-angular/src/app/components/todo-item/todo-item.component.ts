import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Todo } from '../../models/todo';
import { DecimalPipe } from '@angular/common';
import { ButtonComponent } from '../button/button.component';

@Component({
  selector: 'app-todo-item',
  standalone: true,
  imports: [DecimalPipe, ButtonComponent],
  templateUrl: './todo-item.component.html',
  styleUrl: './todo-item.component.css'
})
export class TodoItemComponent {

  @Output() completeTheTask = new EventEmitter<number>();
  @Output() delete = new EventEmitter<number>();

  @Input({ required: true }) todo!: Todo;
  @Input({ required: true }) index!: number;

  completeTask(index: number) {
    this.completeTheTask.emit(index);
  }

  deleteTask(index: number) {
    this.delete.emit(index);
  }
}
