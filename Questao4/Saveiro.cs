using System;

namespace exeClasseAbstrata.Questao4
{
  internal class Saveiro : CarroPicape
  {
    public Saveiro(string modelo, string fabrica, string categoria, string numChassi)
    {
      this.modelo = modelo;
      this.fabrica = fabrica;
      this.categoria = categoria;
      this.numChassi = numChassi;
    }
    public Saveiro()
    {
    }

    public override string ToString()
    {
      return ($"\nModelo: {modelo}\nFábrica: {fabrica}\nCategoria: {categoria}\nNúmero do Chassi: {numChassi}");
    }

  }
}

