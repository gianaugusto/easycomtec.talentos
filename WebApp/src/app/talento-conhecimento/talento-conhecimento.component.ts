import { ConhecimentoComponent } from "../conhecimento/conhecimento.component";
import { ConhecimentoService } from "../conhecimento/conhecimento.service";
import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { TalentoComponent, TalentoBanco, TalentoConhecimento } from "../talento/talento.component";
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

            var talentoCon:TalentoConhecimento;
            this.conhecimentoService = conhecimentoService
            this.conhecimentoService.lista()
            .subscribe(
                conhecimento => {
                    this.conhecimentos = conhecimento
                    
                    this.conhecimentos.forEach(item => {
                        
                        talentoCon = this.talento.conhecimentos.find(x => x.conhecimentoID == item.id);
                        
                        if(talentoCon){
                            talentoCon.titulo =  item.titulo; 
              
                        }else{

                            talentoCon = new TalentoConhecimento();
                            talentoCon.conhecimentoID = item.id;
                            talentoCon.talentoID = this.talento.id;
                            talentoCon.nivel = 0;
                            talentoCon.titulo =  item.titulo;

                            this.talento.conhecimentos.push(talentoCon)
                        }
                    });

                },
                erro => console.log(erro)
            );
    }

    SalvarConhecimento(event){
        event.preventDefault();
        
        this.SalvarDados('/talento/done/');
    }
}
