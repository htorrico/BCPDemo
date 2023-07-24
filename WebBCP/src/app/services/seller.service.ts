import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Seller } from '../models/seller.model';

@Injectable({
  providedIn: 'root'
})
export class SellerService {
  private apiUrl = 'https://tuservidor.com/api'; // Reemplaza con la URL de tu API

  constructor(private http: HttpClient) { }

  getSellers(): Observable<Seller[]> {
    return this.http.get<Seller[]>(`${this.apiUrl}/products`);
  }
}
