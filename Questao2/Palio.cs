using System;

namespace exeClasseAbstrata.Questao2
{
  internal class Palio : CarroPopular
  {
    public Palio(string modelo, string fabrica, string categoria, string numChassi)
    {
      this.modelo = modelo;
      this.fabrica = fabrica;
      this.categoria = categoria;
      this.numChassi = numChassi;
    }

    public override void exibirInfoPopular()
    {
      System.Console.WriteLine($"\nModelo: {modelo}\nFábrica: {fabrica}\nCategoria: {categoria}\nNúmero do Chassi: {numChassi}");
    }



  }
}