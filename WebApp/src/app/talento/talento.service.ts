import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaders } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs/Observable';
import { TalentoComponent } from "./talento.component";

@Injectable()
export class TalentoService {
    http:HttpClient;
    headers:HttpHeaders;
   
    constructor(http:HttpClient) {
        this.http = http;
        this.headers = new HttpHeaders();
        this.headers.append("Content-Type",'application/json');        
    }

    lista(): Observable<TalentoComponent[]> {
        return this
                .http
                .get<TalentoComponent[]>(environment.urlApiTalento);
    }

    cadastrar(Talento:TalentoComponent): Observable<any> {
        if(Talento.id){
            return this.http
            .put(environment.urlApiTalento + '/' + Talento.id,JSON.stringify(Talento),{headers:this.headers});
        }else{
            return this.http
            .post(environment.urlApiTalento,JSON.stringify(Talento),{headers:this.headers});
        }
    }
    
    remover(Talento:TalentoComponent):Observable<Response>{
        return this.http.delete<Response>(environment.urlApiTalento + "/" + Talento.id,{headers:this.headers});
    }

    buscarPorEmail(email:string):Observable<TalentoComponent>{
        return this.http.get<TalentoComponent>(environment.urlApiTalento + "/email/" + email);
    }

}