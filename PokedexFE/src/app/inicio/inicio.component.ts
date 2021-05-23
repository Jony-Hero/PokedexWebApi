import { Component, OnInit } from '@angular/core';
import { Pokemon } from '../_models/pokemon';
import { PokemonService } from '../_services/pokemon.service';
import { first } from 'rxjs/operators';
import {UsersService} from '../_services/usuario.service'
import {
  faTrashAlt,
  faPlus,
  faSort,
  faUserEdit,
  faPencilAlt,
  faEye,
} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-inicio',
  templateUrl: './inicio.component.html',
  styleUrls: ['./inicio.component.css'],
})
export class InicioComponent implements OnInit {
  pokemons = null;
  faEdit = faPencilAlt;
  faTrashAlt = faTrashAlt;
  faPlus = faPlus;
  faUserEdit = faUserEdit;
  faSort = faSort;
  faEye = faEye;
  NumeroP: number;
  poke2: Pokemon[];
  busqueda: string;
  numeroPz: any;
  
  constructor(private pokemonService: PokemonService,private usuarioService: UsersService) {}

  ngOnInit(): void {
    this.pokemonService
      .getAll()
      .pipe(first())
      .subscribe((pokemons) => {
        this.pokemons = pokemons;
        this.poke2 = this.pokemons;
        
      });

    // cargar pokemons y tipos aquí
  }

  borrar(nombre) {
    let si_no = window.confirm(
      '¿Estas seguro de quere borra a ' + nombre + '?'
    );
    if (si_no) {
      this.pokemonService
        .Delete(nombre)
        .subscribe(
          () =>
            (this.pokemons = this.pokemons.filter((c) => c.nombre !== nombre))
        );
    }
  }

  verPokemon() {
    this.poke2=this.pokemons.filter((pokemon) => pokemon.nombre.toLowerCase().includes(this.busqueda.toLowerCase()));
    
   
  }

  logout(){
    this.usuarioService.logout();
  }
}
