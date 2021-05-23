import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
/* import { InicioComponent } from './inicio/inicio.component'; */
import { AppRoutingModule } from './app-routing.module';
import { SingUpComponent } from './sing-up/sing-up.component';
import { HttpClientModule } from '@angular/common/http';
import { CookieService } from 'ngx-cookie-service';
import { InicioComponent } from './inicio/inicio.component';
import { VistaPokeComponent } from './vista-poke/vista-poke.component';

import { ReactiveFormsModule } from '@angular/forms';
/* import { Observable } from "rxjs/Observable"; */
/*  import { VistaPokemonComponent } from './vista-pokemon/vista-pokemon.component'; */
/* import { CrearEditarPokemonComponent } from './crear-editar-pokemon/crear-editar-pokemon.component'  */

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    SingUpComponent,
    VistaPokeComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule

    /* Observable */
  ],
  providers: [CookieService],
  bootstrap: [AppComponent],
})
export class AppModule {}
