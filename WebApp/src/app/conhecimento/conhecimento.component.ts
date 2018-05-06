import {Component, Input} from '@angular/core';

@Component({
    moduleId: module.id,
    selector: 'conhecimento',
    templateUrl: 'conhecimento.component.html',
    styleUrls: ['conhecimento.component.scss']
})
export class ConhecimentoComponent {

    @Input() id:string;

    @Input() titulo:string;

    @Input() valor:number;
}
