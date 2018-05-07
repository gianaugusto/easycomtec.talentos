import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormGroup, FormBuilder,Validators, FormsModule, ReactiveFormsModule  } from "@angular/forms";
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

export class TalentoBasicInfoComponent extends TalentoBase 
{   
    constructor(
        service:TalentoService,  
        dataService: TalentoDataService, 
        router: Router,
        route:ActivatedRoute
    )
    {
        super(service,dataService,router,route);
    }

    BuildValidator(){
        // this.talentoForm = this.formBuilder.group({
        //     nome:['',Validators.compose([Validators.required, Validators.minLength(4)])]
        // });
    }

    SalvarInfo(event){
        event.preventDefault();
        
        this.SalvarDados('/talento/banco/');
    }
}
