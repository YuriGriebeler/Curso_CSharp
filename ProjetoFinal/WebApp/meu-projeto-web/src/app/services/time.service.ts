import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import Time from '../models/time.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TimeService {

  private urlBase = 'http://localhost:5000/';

  constructor(
    public httpClient: HttpClient
  ) { }

  public adicionar(time: Time) {
    return this.httpClient.post<Time>(this.urlBase + 'time/adicionar', time);
  }

  public atualizar(time: Time) {
    return this.httpClient.put<Time>(this.urlBase + 'time/atualizar', time);
  }

  public excluir(id: number) {
    return this.httpClient.delete<any>(this.urlBase + 'time/excluir/' + id);
  }

  public obterPorId(id: number) {
    return this.httpClient.get<Time>(this.urlBase + 'time/obterPorId/' + id);
  }

  public obterTodos() {
    return this.httpClient.get<Time[]>(this.urlBase + 'time/obterTodos');
  }

}
