import { RouterModule, Routes } from '@angular/router';
import { TalentoEmailComponent } from './talento-email/talento-email.component';
import { TalentoBasicInfoComponent } from './talento-basic-info/talento-basic-info.component';
import { TalentoBancoComponent } from './talento-banco/talento-banco.component';
import { TalentoConhecimentoComponent } from './talento-conhecimento/talento-conhecimento.component';
import { TalentoListagemComponent } from "./talento-listagem/talento-listagem.component";
import { TalentoFinishedComponent } from "./talento-finished/talento-finished.component";

const appRoutes: Routes = [
    { path: '', component: TalentoEmailComponent },
    { path: 'talento/listagem', component: TalentoListagemComponent },
    { path: 'talento/:id', component: TalentoEmailComponent },
    { path: 'talento/basic/:id', component: TalentoBasicInfoComponent },
    { path: 'talento/banco/:id', component: TalentoBancoComponent },
    { path: 'talento/conhecimento/:id', component: TalentoConhecimentoComponent },
    { path: 'talento/finished/:id', component: TalentoFinishedComponent },
    { path: '**', redirectTo: '' }
]

export const routing = RouterModule.forRoot(appRoutes)
