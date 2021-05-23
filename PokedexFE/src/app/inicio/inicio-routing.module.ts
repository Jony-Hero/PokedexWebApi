import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import{VistaPokeComponent} from '../vista-poke/vista-poke.component'
import { InicioComponent } from './inicio.component';
const routes: Routes = [
  { path: '',  component: InicioComponent},
  { path: 'vistaPoke',  component: VistaPokeComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class InicioRoutingModule { }
