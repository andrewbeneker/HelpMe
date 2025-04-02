import { Routes } from '@angular/router';
import { TicketListComponent } from './ticket-list/ticket-list.component';
import { CreateUserComponent } from './create-user/create-user.component';
import { CreateTicketComponent } from './create-ticket/create-ticket.component';

export const routes: Routes = [
{path: 'ticket-list', component: TicketListComponent},
{path: 'create-user', component: CreateUserComponent},
{path: 'create-ticket', component: CreateTicketComponent}
];
