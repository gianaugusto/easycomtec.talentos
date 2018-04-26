import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { TalentoComponent, TalentoBanco } from "../talento/talento.component";
import { TalentoService } from "../talento/talento.service";
import { TalentoDataService } from "../talento/talento.data.service";
import { TalentoBase } from "../talento/talento.base";

@Component({
    moduleId: module.id,
    selector: 'talento-basic-info',
    templateUrl: 'talento-basic-info.component.html',
    styleUrls: ['talento-basic-info.component.scss']
})
export class TalentoBasicInfoComponent extends TalentoBase implements OnInit {
    
    constructor(
        service:TalentoService,  
        dataService: TalentoDataService, 
        router: Router,
        route:ActivatedRoute) {
            super(service,dataService,router,route);
    }

    ngOnInit() {
        this.dataService.currentTalentoSource.subscribe(talento => this.talento = talento);
    }

    SalvarInfo(){

        console.log(this.talento);

        this.service.cadastrar(this.talento)
        .subscribe(
            response => {
                
                this.dataService.setTalento(this.talento);

                this.router.navigate(['/talento/basic/',this.talento.id]);
            },
            erro => console.log(erro)
        );
    }
}
