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

    cadastrar(talento:TalentoComponent): Observable<any> {
        if(talento.novo == true){
            return this.http
            .post(environment.urlApiTalento,talento,{headers:this.headers});
            
        }else{
            return this.http
            .put(environment.urlApiTalento + '/' + talento.id,talento);
        }
    }
    
    remover(talentoId:string):Observable<Response>{
        return this.http.delete<Response>(environment.urlApiTalento + "/" + talentoId,{headers:this.headers});
    }

    buscarPorEmail(email:string):Observable<TalentoComponent>{
        return this.http.get<TalentoComponent>(environment.urlApiTalento + "/email/" + email);
    }

    buscarPorId(id:string):Observable<TalentoComponent>{
        console.log(environment.urlApiTalento + "/" + id);
        return this.http.get<TalentoComponent>(environment.urlApiTalento + "/" + id);
    }
}