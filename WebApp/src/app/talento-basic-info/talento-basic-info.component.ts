import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TalentoComponent } from "../talento/talento.component";
import { TalentoService } from "../talento/talento.service";
import { TalentoDataService } from "../talento/talento.data.service";

@Component({
    moduleId: module.id,
    selector: 'talento-basic-info',
    templateUrl: 'talento-basic-info.component.html',
    styleUrls: ['talento-basic-info.component.scss']
})
export class TalentoBasicInfoComponent {
    private talento:TalentoComponent = new TalentoComponent();
    
    constructor(private service:TalentoService, private data: TalentoDataService,private router: Router) {
    }

    ngOnInit() {
        this.data.currentMessage.subscribe(talento => this.talento = talento);
    }
}
