import { Component, OnInit } from '@angular/core';
import { TalentoComponent } from "./talento.component";
import { TalentoService } from "./talento.service";
import { TalentoDataService } from "./talento.data.service";
import { Router, ActivatedRoute } from '@angular/router';
import { FormGroup, FormBuilder,Validators, FormsModule, ReactiveFormsModule  } from "@angular/forms";


export class TalentoBase implements OnInit {
    protected talento:TalentoComponent = new TalentoComponent();
    protected service:TalentoService;
    protected dataService:TalentoDataService;
    protected router:Router;
    protected route:ActivatedRoute;
    protected talentoForm:FormGroup;
    protected id:any;

    constructor(
            service:TalentoService,  
            dataService: TalentoDataService, 
            router: Router,
            route:ActivatedRoute) {
        this.service = service;
        this.dataService = dataService;
        this.router = router;
        this.route = route;

        this.route.params.subscribe(param => {
            let id = param['id'];
        
            console.log('1');

            // console.log(id);
            // if(this.talento == null && id){
            //     this.carregarTelento(id);
            // }
            
        })

    }

    ngOnInit() {

        console.log('3');
        this.dataService.currentTalentoSource.subscribe(talento =>  this.talento = talento );
    }

    carregarTelento(id:string){
        this.service.buscarPorId(id)
        .subscribe(
            talento => {
                    this.talento = talento;

                    console.log(this.talento);
                    
                    if(this.talento ==null)
                        this.talento = new TalentoComponent();
                },
            erro => console.log(erro)
        );
    }

    SalvarDados(navegateTo:string){
        
        this.service.cadastrar(this.talento)
        .subscribe(
            response => {
                
                this.dataService.setTalento(this.talento);

                this.router.navigate([navegateTo,this.talento.id]);
            },
            erro => console.log(erro)
        );
    }
}