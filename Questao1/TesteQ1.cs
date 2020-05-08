using System;
namespace exeClasseAbstrata
{
  internal class TesteQ1
  {
    public static void teste()
    {
      FabricaDeCarros fabrica = new FabricaFiat();
      CarroSedan sedan = fabrica.criarCarroSedan("Siena", "Fiat", "Sedan", "12456432");
      CarroPopular popular = fabrica.criarCarroPopular("Palio", "Fiat", "Hatch", "12335742"); 
    
      sedan.exibirInfoSedan();
      popular.exibirInfoPopular();
    }
  }
}