import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UsersService } from '../_services/usuario.service';

@Component({
  selector: 'app-sing-up',
  templateUrl: './sing-up.component.html',
  styleUrls: ['./sing-up.component.css']
})
export class SingUpComponent implements OnInit {
  usuario:string
  password:string
  password2:string   
  constructor(public userService: UsersService, public router: Router) { }

  ngOnInit(): void {
  }
  
  register() {
    const user = {usurname: this.usuario, password: this.password};
    if(this.password==this.password2){
    this.userService.registro(user).subscribe( data => {
      
     if(data==409){
      window.alert("El usuario ya existe")
     }else{
      this.router.navigateByUrl('/inicio');
     }
    
     
      
    });
  }else{
    window.alert("Las contraseñas no coinciden")
  }
}

  } 

  