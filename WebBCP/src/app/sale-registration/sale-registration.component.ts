import { Component, OnInit } from '@angular/core';
import { CustomerService } from '../services/customer.service';
import { SellerService } from '../services/seller.service';
import { ProductService } from '../services/product.service';
import { SaleService } from '../services/sale.service';
import { Sale } from '../models/sale.model';
import { Customer } from '../models/customer.model';
import { Product } from '../models/product.model';
import { Seller } from '../models/seller.model';

@Component({
  selector: 'app-sale-registration',
  templateUrl: './sale-registration.component.html',
  styleUrls: ['./sale-registration.component.css']
})
export class SaleRegistrationComponent implements OnInit {
  customers: Customer[] = [];
  sellers: Seller[] = [];
  products: Product[] = [];

  selectedCustomer: number | undefined;
  selectedSeller: number | undefined;
  selectedProduct: number | undefined;
  amount: number | undefined;

  confirmationMessage: string = '';

  constructor(
    private customerService: CustomerService,
    private sellerService: SellerService,
    private productService: ProductService,
    private saleService: SaleService
  ) {}

  ngOnInit() {
    // this.getCustomers();
    // this.getSellers();
    // this.getProducts();
  }

  getCustomers() {
    this.customerService.getCustomers().subscribe(
      (data) => {
        this.customers = data;
      },
      (error) => {
        console.error('Error al obtener la lista de clientes: ', error);
      }
    );
  }

  getSellers() {
    this.sellerService.getSellers().subscribe(
      (data) => {
        this.sellers = data;
      },
      (error) => {
        console.error('Error al obtener la lista de vendedores: ', error);
      }
    );
  }

  getProducts() {
    this.productService.getProducts().subscribe(
      (data) => {
        this.products = data;
      },
      (error) => {
        console.error('Error al obtener la lista de productos: ', error);
      }
    );
  }

  saveSale() {
    if (this.selectedCustomer && this.selectedSeller && this.selectedProduct && this.amount) {
      const saleData: Sale = {
        customerId: this.selectedCustomer,
        sellerId: this.selectedSeller,
        productId: this.selectedProduct,
        amount: this.amount        
      };

      this.saleService.saveSale(saleData).subscribe(
        (response) => {
          this.confirmationMessage = '¡Venta registrada con éxito! ID de venta: ' + response.id;
        },
        (error) => {
          console.error('Error al guardar la venta: ', error);
          this.confirmationMessage = 'Ocurrió un error al guardar la venta.';
        }
      );
    } else {
      this.confirmationMessage = 'Por favor, complete todos los campos.';
    }
  }
}
