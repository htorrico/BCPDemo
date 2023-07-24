import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { SaleFormComponent } from './sale-form/sale-form.component';
import { CustomerSelectComponent } from './customer-select/customer-select.component';
import { SellerSelectComponent } from './seller-select/seller-select.component';
import { ProductSelectComponent } from './product-select/product-select.component';
import { SaleRegistrationComponent } from './sale-registration/sale-registration.component';
import { FormsModule } from '@angular/forms';
import { HTTP_INTERCEPTORS, HttpClient, HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AuthInterceptorService } from './interceptors/authInterceptorService';
import { LoginComponent } from './login/login.component';



@NgModule({
  declarations: [
    AppComponent,
    SaleFormComponent,
    CustomerSelectComponent,
    SellerSelectComponent,
    ProductSelectComponent,
    SaleRegistrationComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptorService,
      multi: true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
