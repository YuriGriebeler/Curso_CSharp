
import { Component, OnInit } from '@angular/core';
import Time from 'src/app/models/time.model';
import { AlertService } from 'src/app/services/alert.service';
import { TimeService } from 'src/app/services/time.service';

@Component({
  selector: 'app-time-listagem',
  templateUrl: './time-listagem.component.html',
  styleUrls: ['./time-listagem.component.css']
})
export class TimeListagemComponent implements OnInit {

  public listaTimes: Time[] = [];

  constructor(
    public timeService: TimeService,
    public alertService: AlertService
  ) { }

  public ngOnInit(): void {
    document.title = 'Listagem de times';

    this.obterTimesDaApi();
  }

  public obterTimesDaApi(): void {
    // subscribe: oque o service tem que fazer quando tiver o retorno da api
    this.timeService.obterTodos().subscribe(resposta => {

      if(resposta != null) {
        this.listaTimes = resposta;
      } else {
        this.alertService.showToastrError('Erro na requisição com o servidor');
      }

    });
  }

  public confirmarEExcluir(id: number): void {
    this.alertService.alertConfirm({
      title: 'Atenção',
      text: 'Você deseja realmente excluir o registro?',
      confirmButtonText: 'Sim',
      confirmButtonColor: "green",
      showCancelButton: true,
      cancelButtonText: 'Não',
      cancelButtonColor: "red",
      fn: () =>{
        this.chamarApiParaExcluir(id);
      },
      fnCancel: () => {

      }
    });
  }

  private chamarApiParaExcluir(id: number): void {
    this.timeService.excluir(id).subscribe(resposta => {

      this.alertService.showToastrSuccess('O time foi excluída com sucesso');
      this.obterTimesDaApi();
    });
  }

}
