import { Injectable } from '@angular/core';
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';

import { UsersService } from '../_services/usuario.service';

@Injectable({ providedIn: 'root' })
export class AuthGuard implements CanActivate {
    constructor(
        private router: Router,
        private accountService: UsersService
    ) { }

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
        const usuario = this.accountService.getUsuario; 

        console.log("AUTH GUARD");
        console.log(usuario);
        
        if (usuario)
            return true;
       
        this.router.navigate(['../login'], { queryParams: { returnUrl: state.url } });
        return false;
    }
}