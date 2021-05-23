import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CookieService } from 'ngx-cookie-service';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root',
})
export class UsersService {
  constructor(private http: HttpClient, public router: Router) {}

  login(user: any): Observable<any> {
    return this.http.post('https://localhost:44303/api/LoginControler', user);
  }

  logout() {
    localStorage.removeItem('usuario');
    this.router.navigateByUrl("/login");
  }
  
  registro(user: any): Observable<any> {
    return this.http.post('https://localhost:44303/api/Usuario', user);
  }

  public get getUsuario(): any {
    return localStorage.getItem('usuario');
  }
}
