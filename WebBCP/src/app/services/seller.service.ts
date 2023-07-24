import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Seller } from '../models/seller.model';
import { environment } from "src/environments/environment";

@Injectable({
  providedIn: 'root'
})
export class SellerService {
  private apiUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getSellers(): Observable<Seller[]> {
    return this.http.get<Seller[]>(`${this.apiUrl}/api/user/getSeller`);
  }
}
