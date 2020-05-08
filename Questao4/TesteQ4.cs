using System;
using System.Collections.Generic;
using System.Threading;
namespace exeClasseAbstrata.Questao4
{
  internal class TesteQ4
  {
    static FabricaDeCarros fVW = new FabricaVW();
    static FabricaDeCarros fFiat = new FabricaFiat();
    static Carro obj;

    private static Carro gerarSedan()
    {
      var rnd = new Random();
      int valor = rnd.Next(1, 4);
      if (valor == 1)
      {
        obj = fFiat.criarCarroSedan("Siena", "Fiat", "Sedan", gerarChassi());
        return obj;
      }
      else
      {
        obj = fVW.criarCarroSedan("Voyage", "VW", "Sedan", gerarChassi());
        return obj;
      }
    }
    private static Carro gerarPopular()
    {
      var rnd = new Random();
      int valor = rnd.Next(1, 4);
      if (valor == 1)
      {
        obj = fFiat.criarCarroPopular("Palio", "Fiat", "Hatch", gerarChassi());
        return obj;
      }
      else
      {
        obj = fVW.criarCarroSedan("Gol", "VW", "Hatch", gerarChassi());
        return obj;
      }
    }

    private static Carro gerarPicape()
    {
      var rnd = new Random();
      int valor = rnd.Next(1, 4);
      if (valor == 1)
      {
        obj = fFiat.criarCarroPicape("Strada", "Fiat", "Picape", gerarChassi());
        return obj;
      }
      else
      {
        obj = fVW.criarCarroSedan("Saveiro", "VW", "Picape", gerarChassi());
        return obj;
      }
    }

    private static string gerarChassi()
    {
      string num = "0123456789";
      var rnd = new Random();
      string chassi = "" + num[rnd.Next(0, 10)] + num[rnd.Next(0, 10)] + num[rnd.Next(0, 10)];
      return chassi;
    }

    public static void teste()
    {
      Carro[] vet = new Carro[30];
      int iVet = 0;
      FabricaDeCarros fabrica = new FabricaFiat();

      var rnd = new Random();
      int escolheC;

      while (iVet < 30)
      {
        escolheC = rnd.Next(1, 4);
        switch (escolheC)
        {
          case 1:
            vet[iVet] = gerarSedan();
            iVet++;
            break;
          case 2:
            vet[iVet] = gerarPopular();
            iVet++;
            break;
          case 3:
            vet[iVet] = gerarPicape();
            iVet++;
            break;
        }
      }

      for (int i = 0; i < vet.Length; i++)
      {
        System.Console.WriteLine(vet[i]);
      }
    }
  }
}
