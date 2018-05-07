
import { Component, OnInit } from '@angular/core';
import { TalentoComponent } from "../talento/talento.component";
import { TalentoService } from "../talento/talento.service";

@Component({
    moduleId: module.id,
    selector: 'talento-listagem',
    templateUrl: 'talento-listagem.component.html',
    styleUrls: ['talento-listagem.component.scss']
})

export class TalentoListagemComponent {

    talentos: TalentoComponent[] = [];
    service:TalentoService;
    mensagem:string = "";

    constructor(service:TalentoService) {
        this.service = service
        
        this.service.lista()
            .subscribe(
                talentos => this.talentos = talentos,
                erro => console.log(erro)
            );
    }

    excluir(id:string){
        this.service.remover(id)
        .subscribe(
            result => alert('excluido com sucesso.'),
            erro => console.log(erro)
        );
    }

}
