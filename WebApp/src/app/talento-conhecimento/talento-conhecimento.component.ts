import { ConhecimentoComponent } from "../conhecimento/conhecimento.component";
import { ConhecimentoService } from "../conhecimento/conhecimento.service";
import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { TalentoComponent, TalentoBanco } from "../talento/talento.component";
import { TalentoService } from "../talento/talento.service";
import { TalentoDataService } from "../talento/talento.data.service";
import { TalentoBase } from "../talento/talento.base";

@Component({
    moduleId: module.id,
    selector: 'talento-conhecimento',
    templateUrl: 'talento-conhecimento.component.html',
    styleUrls: ['talento-conhecimento.component.scss']
})

export class TalentoConhecimentoComponent extends TalentoBase implements OnInit {
    
    conhecimentos: ConhecimentoComponent[] = [];
    conhecimentoService:ConhecimentoService;
    mensagem:string = "";

    constructor(
        service:TalentoService,  
        dataService: TalentoDataService, 
        router: Router,
        route:ActivatedRoute, 
        conhecimentoService:ConhecimentoService) {
            super(service,dataService,router,route);

            this.conhecimentoService = conhecimentoService
            this.conhecimentoService.lista()
            .subscribe(
                conhecimento => this.conhecimentos = conhecimento,
                erro => console.log(erro)
            );
    }

    ngOnInit() {
        this.dataService.currentTalentoSource.subscribe(
            talento => 
            {
                this.talento = talento;
    
                this.verificarConhecimento();
            }
        );
    }

    verificarConhecimento(){
        
    }

}
