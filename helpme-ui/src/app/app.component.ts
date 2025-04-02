import { Component } from '@angular/core';
import { RouterOutlet, RouterLink, RouterModule } from '@angular/router';
import { TicketListComponent } from './ticket-list/ticket-list.component';
import { CreateTicketComponent } from './create-ticket/create-ticket.component';
import { CreateUserComponent } from './create-user/create-user.component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, TicketListComponent, CreateTicketComponent, CreateUserComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'helpme-ui';
}
