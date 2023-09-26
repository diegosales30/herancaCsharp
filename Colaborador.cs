using System;

class Colaborador : Pessoa
{
  //atributos
  private double salaraio;

  //constructor
  public Colaborador(string nome, int idade, double salaraio)
  {
    this.nome = nome;
    this.idade = idade;
    this.salaraio = salaraio;

    MsgPeossoa();
    MsgColaborador();
  }

  //metodo
  private void MsgColaborador()
  {
    Console.WriteLine("Salario: " +this.salaraio);
  }
}