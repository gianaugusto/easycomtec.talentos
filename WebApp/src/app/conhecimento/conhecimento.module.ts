// Angular Imports
import { NgModule } from '@angular/core';

// This Module's Components
import { ConhecimentoComponent } from './conhecimento.component';

import { ConhecimentoService } from "./conhecimento.service";

@NgModule({
    imports: [
        
    ],
    declarations: [
        ConhecimentoComponent,
    ],
    exports: [
        ConhecimentoComponent,
    ],
    providers:[
        ConhecimentoService
    ]
})
export class ConhecimentoModule {

}
