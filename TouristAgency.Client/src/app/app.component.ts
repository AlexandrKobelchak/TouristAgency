import { Component, OnInit } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { faCoffee } from '@fortawesome/free-solid-svg-icons';
import {NavMenuComponent} from "./nav-menu/nav-menu.component";
import {WeatherForecastComponent} from "./weather-forecast/weather-forecast.component";
import { RouterOutlet } from '@angular/router';

@Component({
  imports:[WeatherForecastComponent, RouterOutlet, NavMenuComponent, FontAwesomeModule],
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  standalone: true
})
export class AppComponent {

  faCoffee = faCoffee;
  title = 'touristagency';
}
