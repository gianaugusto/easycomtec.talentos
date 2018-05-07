import {Component, Input} from '@angular/core';
import { Guid } from "../tools/Guid";

@Component({
    moduleId: module.id,
    selector: 'talento',
    templateUrl: 'talento.component.html',
    styleUrls: ['talento.component.scss']
})

export class TalentoComponent {

        constructor() {
            
        }

        @Input() id:string;

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
        
        novo:boolean;

        conhecimentos :TalentoConhecimento[];

        banco:TalentoBanco;
        
        public NovoBanco():void {
            this.banco = new TalentoBanco("","","","","","","","");
        }

        public AdicionarBanco(banco:TalentoBanco):void {
            this.banco = banco;
        }

        public NewID():void {
            this.id = Guid.newGuid();
        }

        // public AdicionarConhecimento(conhecimento :TalentoConhecimento) {
        //     this.conhecimentos.push(conhecimento);
        // }

        // public AdicionarConhecimento(conhecimentos :TalentoConhecimento[]) {
        //     var concatConhecimento = this.conhecimentos.concat(conhecimentos);

        //     this.conhecimentos = concatConhecimento;
        // }
}


export class TalentoConhecimento {
    
    @Input() talentoID :string;

    @Input() conhecimentoID :string;

    @Input() nivel :number;

    @Input() titulo : string;
}

export class TalentoBanco {
        
        constructor(
        id :string,

        bancoBeneficiario :string,

        bancoCpf :string,

        bancoNome :string,

        bancoAgencia :string,

        bancoContaCorrente :string,

        bancoContaPoupanca :string,

        bancoConta :string
        ) {
            this.id = id;

            this.bancoBeneficiario = bancoBeneficiario;

            this.bancoCpf = bancoCpf;

            this.bancoNome = bancoNome;

            this.bancoAgencia = bancoAgencia;

            this.bancoContaCorrente = bancoContaCorrente;

            this.bancoContaPoupanca = bancoContaPoupanca;

            this.bancoConta = bancoConta;
        }

        @Input() id :string;

        @Input() bancoBeneficiario :string;

        @Input() bancoCpf :string;

        @Input() bancoNome :string;

        @Input() bancoAgencia :string;

        @Input() bancoContaCorrente :string;

        @Input() bancoContaPoupanca :string;

        @Input() bancoConta :string;
       
}