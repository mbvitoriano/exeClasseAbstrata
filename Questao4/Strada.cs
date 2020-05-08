using System;

namespace exeClasseAbstrata.Questao4
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
    public override string ToString()
    {
      return ($"\nModelo: {modelo}\nFábrica: {fabrica}\nCategoria: {categoria}\nNúmero do Chassi: {numChassi}");
    }


  }
}

