import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms'
import { routing } from './app.routes';

import { HttpModule } from '@angular/http'
import { HttpClient, HttpClientModule, HttpHeaders } from '@angular/common/http';

import { AppComponent } from './app.component';
import { TalentoEmailComponent } from './talento-email/talento-email.component';
import { TalentoBasicInfoComponent } from './talento-basic-info/talento-basic-info.component';
import { TalentoBancoComponent } from './talento-banco/talento-banco.component';
import { TalentoConhecimentoComponent } from './talento-conhecimento/talento-conhecimento.component';
import { TalentoListagemComponent } from "./talento-listagem/talento-listagem.component";
import { TalentoModule } from "./talento/talento.module";
import { ConhecimentoModule } from "./conhecimento/conhecimento.module";
import { TalentoFinishedComponent } from "./talento-finished/talento-finished.component";
@NgModule({
  declarations: [
    AppComponent,
    TalentoEmailComponent,
    TalentoBasicInfoComponent,
    TalentoBancoComponent,
    TalentoConhecimentoComponent,
    TalentoListagemComponent,
    TalentoFinishedComponent
  ],
  imports: [
    BrowserModule,
    FormsModule, 
    routing,
    HttpModule,
    HttpClientModule,
    TalentoModule,
    ConhecimentoModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
