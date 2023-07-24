import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SaleRegistrationComponent } from './sale-registration/sale-registration.component';
import { LoginComponent } from './login/login.component';

const routes: Routes = [
  // { path: '', redirectTo: '/sale-registration', pathMatch: 'full' },
  { path: '', redirectTo: '/login', pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  { path: 'sale-registration', component: SaleRegistrationComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
