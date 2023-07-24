import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SaleRegistrationComponent } from './sale-registration/sale-registration.component';

const routes: Routes = [
  { path: '', redirectTo: '/sale-registration', pathMatch: 'full' },
  { path: 'sale-registration', component: SaleRegistrationComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
