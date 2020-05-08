using System;
using exeClasseAbstrata.Questao1;
using exeClasseAbstrata.Questao2;
using exeClasseAbstrata.Questao3;
using exeClasseAbstrata.Questao4;

namespace exeClasseAbstrata
{
  class Program
  {
    static void Main(string[] args)
    {
      System.Console.WriteLine("=============== Teste da Questão 1 ===============\n");
      TesteQ1.teste();
      System.Console.WriteLine("\n=============== Teste da Questão 2 ===============\n");
      TesteQ2.teste();
      System.Console.WriteLine("\n=============== Teste da Questão 3 ===============\n");
      TesteQ3.teste();
      System.Console.WriteLine("\n=============== Teste da Questão 4 ===============\n");
      TesteQ4.teste();
    }
  }
}
