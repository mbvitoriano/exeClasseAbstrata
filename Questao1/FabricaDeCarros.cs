using System;

namespace exeClasseAbstrata.Questao1
{
  abstract class FabricaDeCarros
  {

    abstract public CarroSedan criarCarroSedan(string modelo, string fabrica, string categoria, string numChassi);
    abstract public CarroPopular criarCarroPopular(string modelo, string fabrica, string categoria, string numChassi);
  }
}
