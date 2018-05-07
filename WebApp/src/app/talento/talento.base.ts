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

    }

    ngOnInit() {
        //if(this.talento.id == null){
        this.dataService.currentTalentoSource.subscribe(
            talento =>  
            {
                console.log('1',this.talento);
                this.talento = <TalentoComponent>talento;
                console.log('2',this.talento);
            }
        
        );
        //}
            
        //if(this.talento.id == null && this.id){
            //this.carregarTelento(id);
        //}

        //this.verificarBanco();

        this.route.params.subscribe(param => {
            let id = param['id'];
           
           //console.log('asdf',this.talento,this.id);
           
       })
    }

    verificarBanco(){
        //console.log(this.talento);

        //console.log(this.talento.banco);

        // console.log("tipo",typeof this.talento);

        // if(this.talento.banco == null){
        //     this.talento.NovoBanco();
        //     this.dataService.setTalento(this.talento);
        // }
        // console.log(this.talento.banco);
    }

    carregarTelento(id:string){
        this.service.buscarPorId(id)
        .subscribe(
            talento => {
                    this.talento = (talento as TalentoComponent);

                    if(this.talento.id == null)
                        this.talento = new TalentoComponent();
                },
            erro => console.log(erro)
        );
    }

    SalvarDados(navegateTo:string){
        console.log("salvar",this.talento);
        
        this.service.cadastrar(this.talento)
        .subscribe(
            response => {
                
                this.talento.novo = false;

                this.dataService.setTalento(this.talento);

                this.router.navigate([navegateTo,this.talento.id]);
            },
            erro => console.log(erro)
        );
    }
}