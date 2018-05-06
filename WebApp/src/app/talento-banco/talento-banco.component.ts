import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { TalentoService } from "../talento/talento.service";
import { TalentoDataService } from "../talento/talento.data.service";
import { TalentoBase } from "../talento/talento.base";
import { TalentoComponent, TalentoBanco, TalentoConhecimento } from "../talento/talento.component";

@Component({
    moduleId: module.id,
    selector: 'talento-banco',
    templateUrl: 'talento-banco.component.html',
    styleUrls: ['talento-banco.component.scss']
})
export class TalentoBancoComponent extends TalentoBase implements OnInit {
    
    constructor(
        service:TalentoService,  
        dataService: TalentoDataService, 
        router: Router,
        route:ActivatedRoute) {
            super(service,dataService,router,route);


            this.verificarBanco();
    }

    verificarBanco(){
        if(this.talento.banco == null){
            //this.talento.AdicionarBanco(new TalentoBanco());
            this.talento.banco = new TalentoBanco();
        }
    }

    SalvarBanco(event){
        event.preventDefault();
        
        this.SalvarDados('/talento/conhecimento/');
    }
}

