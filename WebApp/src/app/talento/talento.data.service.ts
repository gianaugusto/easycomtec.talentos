

import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';
import { TalentoComponent } from "./talento.component";

@Injectable()
export class TalentoDataService {

  private talentoSource = new BehaviorSubject<TalentoComponent>(new TalentoComponent());
  public currentTalentoSource = this.talentoSource.asObservable();

  constructor() { }

  setTalento(talento: TalentoComponent) {
    this.talentoSource.next(talento)
  }

}