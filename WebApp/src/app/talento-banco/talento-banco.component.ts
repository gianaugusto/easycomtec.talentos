import { Component, DoCheck } from '@angular/core';
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
export class TalentoBancoComponent extends TalentoBase implements DoCheck {
    
    constructor(
        service:TalentoService,  
        dataService: TalentoDataService, 
        router: Router,
        route:ActivatedRoute) {
            super(service,dataService,router,route);

           
    }

    ngDoCheck(){
        if(this.talento.banco == null){
            this.talento.NovoBanco();
            this.dataService.setTalento(this.talento);
        }
    }

    SalvarBanco(event){
        event.preventDefault();
        
        this.SalvarDados('/talento/conhecimento/');
    }
}

