import {Component, Input} from '@angular/core';

@Component({
    moduleId: module.id,
    selector: 'talento',
    templateUrl: 'talento.component.html',
    styleUrls: ['talento.component.scss']
})

export class TalentoComponent {

        constructor() {
            //this.id = Guid.newGuid();
        }

        id:string;

        @Input() nome:string;

        @Input() email:string;

        @Input() telefone:string;

        @Input() skype:string;

        @Input() linkedin:string;

        @Input() cidade:string;

        @Input() estado:string;

        @Input() portfolio:string;

        @Input() horasAteQuatro:boolean;

        @Input() horasQuatroASeis:boolean;

        @Input() horasSeisAOito:boolean;

        @Input() horasAcimaDeOito:boolean;

        @Input() horasFimDeSemana:boolean;

        @Input() periodoManha:boolean;

        @Input() periodoTarde:boolean;

        @Input() periodoNoite:boolean;

        @Input() periodoMadrugada:boolean;

        @Input() periodoComercial:boolean;

        @Input() pretensao:number;
        
        @Input() informacaoBancaria:string; 
        
        @Input() linkCrud:string;

        conhecimentos :TalentoConhecimento[];

        banco:TalentoBanco;

        AdicionarBanco(banco:TalentoBanco) {
            this.banco = banco;
        }

        AdicionarConhecimento(conhecimento :TalentoConhecimento) {
            this.conhecimentos.push(conhecimento);
        }

        AdicionarConhecimentos(conhecimentos :TalentoConhecimento[]) {
            var concatConhecimento = this.conhecimentos.concat(conhecimentos);

            this.conhecimentos = concatConhecimento;
        }
}


export class TalentoConhecimento {
    
    @Input() talentoID :string;

    @Input() conhecimentoID :string;

    @Input() nivel :number;
}

export class TalentoBanco {
    
        @Input() id :string;

        @Input() bancoBeneficiario :string;

        @Input() bancoCpf :string;

        @Input() bancoNome :string;

        @Input() bancoAgencia :string;

        @Input() bancoContaCorrente :string;

        @Input() bancoContaPoupanca :string;

        @Input() bancoConta :string;
       
}