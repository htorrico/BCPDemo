import { Component } from '@angular/core';
import { Login } from '../models/login.model';
import { AuthService } from '../services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  userName : string = "";
  password : string = "";
  confirmationMessage: string = '';

  constructor(private authService: AuthService, private router: Router) {}

  login(){
    if (this.userName && this.password) {
      const loginData: Login = {
        userName: this.userName,
        password: this.password,
      };

      this.authService.login(loginData).subscribe(
        (response) => {
          localStorage.setItem("token", response);
          this.router.navigateByUrl('/sale-registration');
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
