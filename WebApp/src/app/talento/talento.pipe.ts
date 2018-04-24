import { Pipe, PipeTransform } from "@angular/core";
import { TalentoComponent } from "./talento.component";

@Pipe({
    name:'filtroPorNome'
})

export class filtroPorNome implements PipeTransform {
   
    transform(fotos:TalentoComponent[],digitado:string){

        digitado = digitado.toLocaleLowerCase();

        return fotos.filter(foto =>  foto.nome != undefined).filter(foto =>  foto.nome.toLowerCase().includes(digitado)); 
    }
}