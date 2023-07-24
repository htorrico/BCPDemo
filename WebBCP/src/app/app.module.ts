import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { SaleFormComponent } from './sale-form/sale-form.component';
import { CustomerSelectComponent } from './customer-select/customer-select.component';
import { SellerSelectComponent } from './seller-select/seller-select.component';
import { ProductSelectComponent } from './product-select/product-select.component';
import { SaleRegistrationComponent } from './sale-registration/sale-registration.component';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
  declarations: [
    AppComponent,
    SaleFormComponent,
    CustomerSelectComponent,
    SellerSelectComponent,
    ProductSelectComponent,
    SaleRegistrationComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
