using System;
namespace exeClasseAbstrata.Questao2
{
  internal class TesteQ2
  {
    public static void teste()
    {
      FabricaDeCarros fabrica = new FabricaFiat();
      CarroSedan sedan = fabrica.criarCarroSedan("Siena", "Fiat", "Sedan", "12456432");
      CarroPopular popular = fabrica.criarCarroPopular("Palio", "Fiat", "Hatch", "12335742");
      CarroPicape picape = fabrica.criarCarroPicape("Strada", "Fiat", "Picape", "123568479");


      sedan.exibirInfoSedan();
      popular.exibirInfoPopular();
      picape.exibirInfoPicape();
    }
  }
}