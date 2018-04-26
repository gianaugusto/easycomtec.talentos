import { TalentoComponent } from "./talento.component";
import { TalentoService } from "./talento.service";
import { TalentoDataService } from "./talento.data.service";
import { Router, ActivatedRoute } from '@angular/router';


export class TalentoBase {
    protected talento:TalentoComponent = new TalentoComponent();
    protected service:TalentoService;
    protected dataService:TalentoDataService;
    protected router:Router;
    protected route:ActivatedRoute;

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
            
            if(id){
                // aqui buscar do banco 
            
            }
            
        })
    }

    carregarTelento(id:string){
        this.service.buscarPorId(id)
        .subscribe(
            talento => {
                this.talento = talento;

                if(this.talento ==null)
                    this.talento = new TalentoComponent();
                },
            erro => console.log(erro)
        );
    }
}