import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaders } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs/Observable';
import { ConhecimentoComponent } from "./Conhecimento.component";

@Injectable()
export class ConhecimentoService {
    http:HttpClient;
    headers:HttpHeaders;
   
    constructor(http:HttpClient) {
        this.http = http;
        this.headers = new HttpHeaders();
        this.headers.append("Content-Type",'application/json');        
    }

    lista(): Observable<ConhecimentoComponent[]> {
        return this
                .http
                .get<ConhecimentoComponent[]>(environment.urlApiConhecimento);
    }

}