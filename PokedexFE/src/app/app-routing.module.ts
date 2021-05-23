import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { SingUpComponent } from './sing-up/sing-up.component';
import { InicioComponent } from './inicio/inicio.component';
import { AuthGuard } from './_helpers';
/* import { InicioComponent } from './inicio/inicio.component'; */

const routes: Routes = [
  /* { path: '', component: InicioComponent, loadChildren: () => import('./inicio/inicio.module').then(x => x.InicioModule), canActivate: [AuthGuard] }, */
  { path: 'login', component: LoginComponent },
  { path: 'signup', component: SingUpComponent },
  {
    path: 'inicio',
    loadChildren: () =>
      import('./inicio/inicio.module').then((x) => x.InicioModule),
    canActivate: [AuthGuard],
  },
  { path: '**', redirectTo: 'login' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
