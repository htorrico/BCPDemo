import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Sale } from '../models/sale.model';

@Injectable({
  providedIn: 'root'
})
export class SaleService {
  private apiUrl = 'https://tuservidor.com/api'; // Reemplaza con la URL de tu API

  constructor(private http: HttpClient) { }

  saveSale(saleData: Sale): Observable<any> {
    return this.http.post<any>(`${this.apiUrl}/Sale/Add`, saleData);
  }
}
