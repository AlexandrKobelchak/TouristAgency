import { Component, OnInit } from '@angular/core';
import { NavMenuComponent } from "./nav-menu/nav-menu.component";
import { RouterOutlet } from '@angular/router';

@Component({
  imports:[RouterOutlet, NavMenuComponent, ],
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  standalone: true
})
export class AppComponent {

  title = 'touristagency';
}
