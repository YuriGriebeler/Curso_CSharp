
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import Time from 'src/app/models/time.model';
import { AlertService } from 'src/app/services/alert.service';
import { TimeService } from 'src/app/services/time.service';

@Component({
  selector: 'app-time-cadastro',
  templateUrl: './time-cadastro.component.html',
  styleUrls: ['./time-cadastro.component.css']
})
export class TimeCadastroComponent implements OnInit {

  public formulario: FormGroup;
  public formSubmetido: boolean = false;
  public id: number = null;

  constructor(
    public formBuilder: FormBuilder,
    public router: Router,
    public activatedRoute: ActivatedRoute,
    public timeService: TimeService,
    public alertService: AlertService
  ) { }

  public ngOnInit(): void {
    this.id = this.activatedRoute.snapshot.params['id'];

    if(this.id == null) {
      document.title = 'Cadastro de time';
    } else {
      document.title = 'Edição de time';
      this.chamarApiParaObterTimePorId(this.id);
    }

    this.inicializarConfigForm();
  }

  public submeterForm(): void {
    this.formSubmetido = true;

    if(this.formulario.invalid) {
      return;
    }

    let time: Time = new Time(this.formulario.getRawValue());

    if(this.id == null) {
      this.chamarApiParaAdicionar(time);
    } else {
      this.chamarApiParaAtualizar(time);
    }

  }

  private inicializarConfigForm(): void {
    this.formulario = this.formBuilder.group({
      id: [0],
      nome: [null, [Validators.required, Validators.maxLength(100)]],
      divisao: [null, [Validators.required, Validators.maxLength(14)]],
      nometecnico: [null, [Validators.email]],
      cidade: [null, [Validators.maxLength(30)]],
    });
  }

  public chamarApiParaAdicionar(time: Time): void {
    this.timeService.adicionar(time).subscribe(resposta => {

      if(resposta != null) {
        this.alertService.showToastrSuccess('Time cadastrada com sucesso');
        this.router.navigate(['/time/listagem']);
      } else {
        this.alertService.showToastrError('Erro ao cadastrar time');
      }

    });
  }

  public chamarApiParaAtualizar(time: Time): void {
    this.timeService.atualizar(time).subscribe(resposta => {

      if(resposta != null) {
        this.alertService.showToastrSuccess('Time atualizada com sucesso');
        this.router.navigate(['/time/listagem']);
      } else {
        this.alertService.showToastrError('Erro ao atualizar time');
      }

    });
  }

  public chamarApiParaObterTimePorId(id: number): void {
    this.timeService.obterPorId(id).subscribe(resposta => {

      if(resposta != null) {
        this.formulario.patchValue(resposta);
      }

    });
  }

}