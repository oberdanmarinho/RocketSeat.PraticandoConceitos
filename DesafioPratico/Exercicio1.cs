using System;
using System.Collections.Generic;

namespace DesafioPratico
{
  class Exercicio1
  {
    public static void Executar()
    {
      Console.WriteLine("Informe seu nome na linha abaixo:");
      string nome = Console.ReadLine() ?? "Usuário não informado";

      Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
    }
  }
}