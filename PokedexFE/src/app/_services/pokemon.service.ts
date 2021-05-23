import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import{Pokemon} from "../_models/pokemon";
import { BehaviorSubject, Observable } from 'rxjs';
@Injectable({
  providedIn: "root"
})
export class PokemonService {
  constructor(private http: HttpClient) {}

  getAll(){
    return this.http.get("https://localhost:44303/api/Pokemon");
  }

   Update(pokemon){
    return this.http.put("https://localhost:44303/api/Pokemon", pokemon);
  }

  Delete(NombreP){
    return this.http.delete("https://localhost:44303/api/Pokemon?Nombre="+NombreP);
  }

  getNumeroP(NumeroP){
    return this.http.get("https://localhost:44303/api/Pokemon/id?numeroP="+NumeroP);
  }
}