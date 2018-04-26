import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { TalentoComponent } from "../talento/talento.component";
import { TalentoService } from "../talento/talento.service";
import { TalentoDataService } from "../talento/talento.data.service";
import { TalentoBase } from '../talento/talento.base';

@Component({
    moduleId: module.id,
    selector: 'talento-email',
    templateUrl: 'talento-email.component.html',
    styleUrls: ['talento-email.component.scss']
})
export class TalentoEmailComponent extends TalentoBase { //implements OnInit {
    
    constructor(
        service:TalentoService,  
        dataService: TalentoDataService, 
        router: Router,
        route:ActivatedRoute) {
            super(service,dataService,router,route);
    }

    // ngOnInit() {
    //     this.dataService.currentTalentoSource.subscribe(talento => this.talento = talento)
    // }

    buscarPorEmail(email:string){
        this.service.buscarPorEmail(email)
        .subscribe(
            talento => {
                this.talento = talento;

                if(this.talento ==null)
                    this.talento = new TalentoComponent();

                this.dataService.setTalento(this.talento);

                this.router.navigate(['/talento/basic/',talento.id]);
            },
            erro => console.log(erro)
        );
    }
}
