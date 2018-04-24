import { Component } from '@angular/core';
import { ConhecimentoComponent } from "../conhecimento/conhecimento.component";
import { ConhecimentoService } from "../conhecimento/conhecimento.service";

@Component({
    moduleId: module.id,
    selector: 'talento-conhecimento',
    templateUrl: 'talento-conhecimento.component.html',
    styleUrls: ['talento-conhecimento.component.scss']
})

export class TalentoConhecimentoComponent {

    conhecimentos: ConhecimentoComponent[] = [];
    service:ConhecimentoService;
    mensagem:string = "";

    constructor(service:ConhecimentoService) {
        this.service = service
        
        this.service.lista()
            .subscribe(
                conhecimento => this.conhecimentos = conhecimento,
                erro => console.log(erro)
            );

    }


}
