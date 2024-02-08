import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-name-list',
  standalone: true,
  imports: [],
  templateUrl: './name-list.component.html',
  styleUrl: './name-list.component.css'
})
export class NameListComponent {
  @Input({ required: true }) names!: string[];
}
