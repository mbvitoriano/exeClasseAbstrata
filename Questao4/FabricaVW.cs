using System;

namespace exeClasseAbstrata.Questao4
{
  internal class FabricaVW : FabricaDeCarros
  {

    public override CarroSedan criarCarroSedan(string modelo, string fabrica, string categoria, string numChassi)
    {
      Voyage obj = new Voyage(modelo, fabrica, categoria, numChassi);
      return obj;
    }

    public override CarroPopular criarCarroPopular(string modelo, string fabrica, string categoria, string numChassi)
    {
      Gol obj = new Gol(modelo, fabrica, categoria, numChassi);
      return obj;
    }
    public override CarroPicape criarCarroPicape(string modelo, string fabrica, string categoria, string numChassi)
    {
      Saveiro obj = new Saveiro(modelo, fabrica, categoria, numChassi);
      return obj;
    }
  }
}

