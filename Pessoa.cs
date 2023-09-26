using System;

class Pessoa
{
  //atributos protected
  //apenas a classe que possui esse modificador ou classes que extendem podem utilizar
  protected string? nome;
  protected int idade;


  //metodo
  protected void MsgPeossoa()
  {
    Console.WriteLine("Nome: " +this.nome);
    Console.WriteLine("Idade: " +this.idade);
  }
}