import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterModule, RouterLink } from '@angular/router';
import { TicketService } from '../ticket.service';

@Component({
  selector: 'app-ticket-list',
  imports: [CommonModule, FormsModule, RouterModule],
  templateUrl: './ticket-list.component.html',
  styleUrl: './ticket-list.component.css'
})
export class TicketListComponent implements OnInit {

  constructor(private ticketService: TicketService){}

  tickets: any[]= [];
  id!: number;


ngOnInit(): void {
    this.loadTickets();
}

loadTickets(): void {
  this.ticketService.getTickets().subscribe((data: any) => {
    this.tickets = data;
  })
}

  getTicketById(): void {
    this.ticketService.getTicketById(this.id).subscribe();
  }

}
