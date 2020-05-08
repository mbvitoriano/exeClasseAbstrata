using System;

namespace exeClasseAbstrata.Questao2
{
  internal class Strada : CarroPicape
  {
    public Strada(string modelo, string fabrica, string categoria, string numChassi)
    {
      this.modelo = modelo;
      this.fabrica = fabrica;
      this.categoria = categoria;
      this.numChassi = numChassi;
    }
    public Strada()
    {
    }
    public override void exibirInfoPicape()
    {
      System.Console.WriteLine($"\nModelo: {modelo}\nFábrica: {fabrica}\nCategoria: {categoria}\nNúmero do Chassi: {numChassi}");
    }


  }
}

