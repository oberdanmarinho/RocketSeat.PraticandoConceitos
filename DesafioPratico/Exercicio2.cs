using System;
using System.Collections.Generic;

namespace DesafioPratico
{
  class Exercicio2
  {
    public static void Executar()
    {
      Console.WriteLine("Exercício 2\n");
      Console.WriteLine("Olá seja bem vindo. Informe seu primeiro nome na linha abaixo:");
      string nome = Console.ReadLine() ?? "Usuário não informado";

      Console.WriteLine("Agora, insira o seu sobrenome  na linha abaixo:");
      string sobrenome = Console.ReadLine() ?? "Sobrenome não informado";

      Console.WriteLine($"Olá, {nome + " " + sobrenome}! Seja muito bem-vindo!");
    }
  }
}