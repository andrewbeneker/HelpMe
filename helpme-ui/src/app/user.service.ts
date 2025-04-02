import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UserService {

private baseUrl = 'https://localhost:7137/api/User'

  constructor(private http: HttpClient) { }

  createUser(user: { UserName: string, Email: string, Password: number;}) {
    return this.http.post(`${this.baseUrl}/`, user);
  }

}
