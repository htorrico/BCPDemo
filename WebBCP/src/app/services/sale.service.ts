import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Sale } from '../models/sale.model';
import { environment } from "src/environments/environment";

@Injectable({
  providedIn: 'root'
})
export class SaleService {
  private apiUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  saveSale(saleData: Sale): Observable<any> {
    return this.http.post<any>(`${this.apiUrl}/Api/Sale/Add`, saleData);
  }
}
