export default class Time {
  public id: number;
  public nome: string;
  public divisao: string;
  public nometecnico: string;
  public cidade: string;

  constructor(obj?: any) {
    if (obj != null) {
        Object.assign(this, obj);
    }
  }

}