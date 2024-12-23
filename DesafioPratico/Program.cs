using System;
using System.Collections.Generic;

namespace DesafioPratico
{
  class DesafioPratico
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Escolha o desafio que deseja executar:");
      Console.WriteLine("- 1 -");
      Console.WriteLine("- 2 -");
      Console.WriteLine("- 3 -");
      Console.WriteLine("- 4 -");
      Console.WriteLine("- 5 -");
      Console.WriteLine("- 6 -");

      string desafio = Console.ReadLine() ?? "Nenhuma opção informada";

      switch (desafio)
      {
        case "1":
          Exercicio1.Executar();
          break;

        case "2":
          Exercicio2.Executar();
          break;

        default:
          Console.WriteLine("Desafio não encontrado.");
          break;
      }
    }
  }
}
