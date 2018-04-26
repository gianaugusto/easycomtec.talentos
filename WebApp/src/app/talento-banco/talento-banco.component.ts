import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { TalentoComponent, TalentoBanco } from "../talento/talento.component";
import { TalentoService } from "../talento/talento.service";
import { TalentoDataService } from "../talento/talento.data.service";
import { TalentoBase } from "../talento/talento.base";

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
    }

    ngOnInit() {
        this.dataService.currentTalentoSource.subscribe(
            talento => 
            {
                this.talento = talento;
    
                this.verificarBanco();
            }
        );
    }

    verificarBanco(){
        if(this.talento.banco == null){
            this.talento.AdicionarBanco(new TalentoBanco());
        }
    }

    SalvarBanco(){
        this.service.cadastrar(this.talento)
        .subscribe(
            response => {
                
                this.dataService.setTalento(this.talento);

                this.router.navigate(['/talento/conhecimento/',this.talento.id]);
            },
            erro => console.log(erro)
        );
    }
}

