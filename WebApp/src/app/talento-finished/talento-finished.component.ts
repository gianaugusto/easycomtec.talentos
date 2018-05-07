
import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { TalentoService } from "../talento/talento.service";
import { TalentoDataService } from "../talento/talento.data.service";
import { TalentoBase } from "../talento/talento.base";
import { TalentoComponent, TalentoBanco, TalentoConhecimento } from "../talento/talento.component";

@Component({
    moduleId: module.id,
    selector: 'talento-finished',
    templateUrl: 'talento-finished.component.html',
    styleUrls: ['talento-finished.component.scss']
})

export class TalentoFinishedComponent extends TalentoBase implements OnInit {
    
    constructor(
        service:TalentoService,  
        dataService: TalentoDataService, 
        router: Router,
        route:ActivatedRoute) {
            super(service,dataService,router,route);
    }
}

