import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[];
  public reservations: Reservation[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    debugger
    http.get<Reservation[]>(baseUrl + 'api/Reservations').subscribe(result => {
      this.reservations = result;
    }, error => console.error(error));
  }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

interface Room {
  id: number;
  number: number;
  name: string;
  status: string;
  allowedSmoking: boolean;
}

interface Guest {
  id: number;
  name: string;
  registerDate: Date;
}

interface Reservation {
  checkinDate: Date;
  checkoutDate: Date;
  room: Room;
  guest: Guest;
}
