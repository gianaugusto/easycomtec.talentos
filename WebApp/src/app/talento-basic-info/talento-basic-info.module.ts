// Angular Imports
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

// This Module's Components
import { TalentoBasicInfoComponent } from './talento-basic-info.component';
import { TalentoService } from "../talento/talento.service";

@NgModule({
    imports: [
        FormsModule,
        ReactiveFormsModule
    ],
    declarations: [
        TalentoBasicInfoComponent,
    ],
    exports: [
        TalentoBasicInfoComponent, TalentoService
    ]
})
export class TalentoBasicInfoModule {

}
