import { NgModule } from '@angular/core';
import { TalentoComponent } from './talento.component';
import { TalentoService } from "./talento.service";
import { filtroPorNome } from "./talento.pipe";
import { TalentoDataService } from "./talento.data.service";
@NgModule({
    imports: [

    ],
    declarations: [
        TalentoComponent, filtroPorNome
    ],
    exports: [
        TalentoComponent, filtroPorNome
    ],
    providers:[TalentoService,TalentoDataService]
})

export class TalentoModule {

}
