import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TalentoComponent } from "../talento/talento.component";
import { TalentoService } from "../talento/talento.service";
import { TalentoDataService } from "../talento/talento.data.service";

@Component({
    moduleId: module.id,
    selector: 'talento-email',
    templateUrl: 'talento-email.component.html',
    styleUrls: ['talento-email.component.scss']
})
export class TalentoEmailComponent implements OnInit {

    private talento:TalentoComponent = new TalentoComponent();
    
    constructor(private service:TalentoService, private data: TalentoDataService,private router: Router) {
    }

    ngOnInit() {
        this.data.currentMessage.subscribe(talento => this.talento = talento)
    }

    buscarPorEmail(email:string){
        this.service.buscarPorEmail(email)
        .subscribe(
            talento => {
                this.talento = talento;

                if(this.talento ==null)
                    this.talento = new TalentoComponent();

                this.data.setTalento(this.talento);

                this.router.navigate(['/talento/basic/',talento.id]);
            },
            erro => console.log(erro)
        );
    }
}
