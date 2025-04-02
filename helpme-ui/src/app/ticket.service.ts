import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TicketService {

  private baseUrl = 'https://localhost:7137/api/Tickets'

  

  constructor(private http: HttpClient) { }

  getTickets(): any {
      return this.http.get(this.baseUrl);
  };

  getTicketById(id: number): any {
    return this.http.get(`${this.baseUrl}/Tickets/${id}`);
  }

  updateTicket(id: number, Name: string) {
    return this.http.put(`${this.baseUrl}/Tickets/${id}`, Name);
  }

  createTicket(ticket: { Name: string, Email: string, Title: string, Body: string }) {
    return this.http.post(`${this.baseUrl}/Tickets`, ticket);
  }

}
