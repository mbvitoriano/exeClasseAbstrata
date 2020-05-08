using System;

namespace exeClasseAbstrata
{
  internal class FabricaFiat : FabricaDeCarros
  {

    public override CarroSedan criarCarroSedan(string modelo, string fabrica, string categoria, string numChassi)
    {
      Siena obj = new Siena(modelo, fabrica, categoria, numChassi);
      return obj;
    }

    public override CarroPopular criarCarroPopular(string modelo, string fabrica, string categoria, string numChassi)
    {
      Palio obj = new Palio(modelo, fabrica, categoria, numChassi);
      return obj;
    }
  }
}

