using System;

namespace exeClasseAbstrata.Questao4
{
  abstract class Carro
  {
    protected string modelo, fabrica, categoria, numChassi;

    public abstract override string ToString();
  }
}