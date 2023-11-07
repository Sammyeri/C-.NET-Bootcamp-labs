import { Component } from '@angular/core';
import { MenuItem } from './models/MenuItem';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'menu';

  menuitems :MenuItem[] = [{Name: "Chicken Fingers", Category: "dinner", Price: 11.99},
    {Name: "Pizza", Category: "dinner", Price: 11.99},
    {Name: "Wings", Category: "sides", Price: 8.99},
    {Name: "Breadsticks", Category: "sides", Price: 4.99},
    {Name: "Ceasear Salad", Category: "salads", Price: 5.99},
    {Name: "Cinnamon Roll", Category: "dessert", Price: 8.99}]
}
