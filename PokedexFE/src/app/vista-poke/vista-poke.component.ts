import { Component, OnInit } from '@angular/core';
import { Pokemon } from '../_models/pokemon';
import { Router, ActivatedRoute } from '@angular/router';
import { PokemonService } from '../_services/pokemon.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { first } from 'rxjs/operators';
import { TemplateDefinitionBuilder } from '@angular/compiler/src/render3/view/template';
@Component({
  selector: 'app-vista-poke',
  templateUrl: './vista-poke.component.html',
  styleUrls: ['./vista-poke.component.css'],
})
export class VistaPokeComponent implements OnInit {
  numeroP: number;
  form: FormGroup;
  pokemon: Pokemon;
  pokemon2: Pokemon;
  modoEditar: boolean = false;

  constructor(
    public router: Router,
    public formBuilder: FormBuilder,
    public route: ActivatedRoute,
    public pokemonService: PokemonService
  ) {}

  ngOnInit(): void {
    this.numeroP = window.history.state.numeroP;
    this.modoEditar = window.history.state.modoEditar;
    if (!this.numeroP) {
      this.router.navigateByUrl('/inicio');
    }
    this.form = this.formBuilder.group({
      numeroP: ['', Validators.required],
      nombre: ['', Validators.required],
      descripcion: [, Validators.required],
      altura: ['', Validators.required],
      peso: ['', Validators.required],
      categoria: [, Validators.required],
      habilidad: ['', Validators.required],
      tipo: ['', Validators.required],
      imagen: [, Validators.required],
    });
    console.log('numero', this.numeroP);

    this.pokemonService
      .getNumeroP(this.numeroP)
      .pipe(first())
      .subscribe((pokemon: Pokemon) => {
        this.pokemon = pokemon;
        console.log(this.pokemon);
        this.form.patchValue(pokemon);
      });
    console.log(this.pokemon);
  }

  onSubmit() {
    if (this.modoEditar) {
      /* this.crearCategoria();
       */
    } else {
      this.editarPokemon();
    }
  }

  private editarPokemon() {
    this.pokemonService.Update(this.form.value).pipe(first())
    .subscribe((x) => {
      console.log(this.form.value);
      console.log(x);
      this.router.navigateByUrl('/inicio');
    });
    
    /* .subscribe({
      next: () => {
        console.log(this.form.value);
        this.router.navigate(['/inicio'], { relativeTo: this.route });
      },
    }); */
  }
}
