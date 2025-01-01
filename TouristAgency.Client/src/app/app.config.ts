import { provideRouter, Routes } from "@angular/router";
import { ApplicationConfig } from "@angular/core";

// компоненты, которые сопоставляются с маршрутами
import {HomePageComponent} from "./home-page/home-page.component";
import {AboutPageComponent} from "./about-page/about-page.component";
import {ClientAddComponent} from "./client-add/client-add.component";
import {ClientFindComponent} from "./client-find/client-find.component";
import {WeatherForecastComponent} from "./weather-forecast/weather-forecast.component";
import {PageNotFoundComponent} from "./page-not-found/page-not-found.component";
import { provideHttpClient } from "@angular/common/http";

// определение маршрутов
const appRoutes: Routes =[
  { path: "", component: HomePageComponent},
  { path: "home", component: HomePageComponent},
  { path: "weather", component: WeatherForecastComponent},
  { path: "client-add", component: ClientAddComponent},
  { path: "client-find", component: ClientFindComponent},
  { path: "about", component: AboutPageComponent},
  { path: "**", component: PageNotFoundComponent }
];

export const appConfig: ApplicationConfig = {
  providers: [
    provideRouter(appRoutes),
    provideHttpClient(),
  ]
};
