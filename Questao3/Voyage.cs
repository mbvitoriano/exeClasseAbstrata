using System;

namespace exeClasseAbstrata.Questao3
{
  internal class Voyage : CarroSedan
  {
    public Voyage(string modelo, string fabrica, string categoria, string numChassi)
    {
      this.modelo = modelo;
      this.fabrica = fabrica;
      this.categoria = categoria;
      this.numChassi = numChassi;
    }

    public Voyage()
    {
    }
    public override void exibirInfoSedan()
    {
      System.Console.WriteLine($"\nModelo: {modelo}\nFábrica: {fabrica}\nCategoria: {categoria}\nNúmero do Chassi: {numChassi}");
    }


  }
}

