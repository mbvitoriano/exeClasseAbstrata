using System;

namespace exeClasseAbstrata.Questao2
{
  internal class Siena : CarroSedan
  {
    public Siena(string modelo, string fabrica, string categoria, string numChassi)
    {
      this.modelo = modelo;
      this.fabrica = fabrica;
      this.categoria = categoria;
      this.numChassi = numChassi;
    }

    public Siena()
    {
    }
    public override void exibirInfoSedan()
    {
      System.Console.WriteLine($"\nModelo: {modelo}\nFábrica: {fabrica}\nCategoria: {categoria}\nNúmero do Chassi: {numChassi}");
    }


  }
}

