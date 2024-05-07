import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CoffeeLogsComponent } from './coffee-logs/coffee-logs.component';

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  imports: [RouterOutlet, CoffeeLogsComponent],
})
export class AppComponent {}
