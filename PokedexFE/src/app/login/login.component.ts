import { Component, OnInit } from '@angular/core';
import { UsersService } from '../_services/usuario.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent implements OnInit {
  usuario: string;
  password: string;
  logeado: boolean;
  constructor(public userService: UsersService, public router: Router) {}

  ngOnInit(): void {}

  logearse() {
    const user = { username: this.usuario, password: this.password };
    this.userService.login(user).subscribe((data) => {
      this.logeado = data;
      if (data == true) {
        localStorage.setItem('usuario', user.username);
        this.router.navigateByUrl('/inicio');
      } else {
        console.error(data);
        window.alert('ha habido un error');
      }
    });
  }
}
