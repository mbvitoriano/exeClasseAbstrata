using System;
namespace exeClasseAbstrata.Questao3
{
  internal class TesteQ3
  {
    public static void teste()
    {
      FabricaDeCarros fabrica = new FabricaVW();
      CarroSedan sedan = fabrica.criarCarroSedan("Voyage", "VW", "Sedan", "324675434");
      CarroPopular popular = fabrica.criarCarroPopular("Gol", "VW", "Hatch", "423543632");
      CarroPicape picape = fabrica.criarCarroPicape("Saveiro", "VW", "Picape", "42434564365");


      sedan.exibirInfoSedan();
      popular.exibirInfoPopular();
      picape.exibirInfoPicape();


    }
  }
}