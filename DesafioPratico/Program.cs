﻿namespace DesafioPratico
{
  static class DesafioPratico
  {
    static void Main()
    {
      while (true)
      {
        ExibirDesafio();

        string desafio = Console.ReadLine()?.Trim().ToUpper() ?? "";

        if (desafio == "E")
          if (desafio == "S")
          {
            Console.WriteLine("Aplicação encerrada.");
            break;
          }

        if (!ExecutarDesafio(desafio))
        {
          Console.WriteLine("\nDesafio não encontrado! Tente novamente");
          Console.WriteLine("Presisone Enter para continuar...");
          Console.ReadKey();
        }

        if (!PedirContinuacao())
        {
          Console.WriteLine("Aplicação encerrada.");
          return;
        }
      }
    }

    static void ExibirDesafio()
    {
      Console.Clear();
      Console.WriteLine("\u2591 Desafio Prático RocketSeat\n");
      Console.WriteLine(" Escolha o desafio que deseja executar:\n");
      Console.WriteLine("\u2022 1 \u25B6 Seu nome \u2714");
      Console.WriteLine("\u2022 2 \u25B6 Nome e sobrenome \u2714");
      Console.WriteLine("\u2022 3 \u25B6 Resultado dos números \u2714");
      Console.WriteLine("\u2022 4 \u25B6 Contador de Caracteres \u2714");
      Console.WriteLine("\u2022 5 \u25B6 Validador de placa \u2714");
      Console.WriteLine("\u2022 6 \u25B6 Data Atual (Formatos)\n\n");
      Console.WriteLine("\u25B6 (E) \u25B6 Exit");
      Console.WriteLine("Escolha o desafio que deseja executar:\n");
      Console.WriteLine("- 1 - Seu nome - DONE");
      Console.WriteLine("- 2 - Seu nome e seu sobrenome - DONE");
      Console.WriteLine("- 3 - Resultado dos números");
      Console.WriteLine("- 4 - Quantos Caracteres - DONE");
      Console.WriteLine("- 5 - Placa Válida");
      Console.WriteLine("- 6 - Data Atual - formatos\n");
      Console.WriteLine("- S - Sair");
    }

    static bool ExecutarDesafio(string desafio)
    {
      switch (desafio)
      {
        case "1":
          Exercicio1.Executar();
          return true;
        case "2":
          Exercicio2.Executar();
          return true;
        case "3":
          Exercicio3.Executar();
          return true;
        case "4":
          Exercicio4.Executar();
          return true;
        case "5":
          Exercicio5.Executar();
          return true;
        case "6":
          Exercicio6.Executar();
          return true;
        default:
          return false;
      }
    }

    static bool PedirContinuacao()
    {
      while (true)
      {
        Console.WriteLine("\nDeseja executar outro desafio ? S - Sim | N - Não");
        string resposta = Console.ReadLine()?.ToUpper() ?? string.Empty;

        if (resposta == "S")
          return true;
        if (resposta == "N")
          return false;

        Console.WriteLine("Opção invalida. Digite apenas 'S' para sim ou 'N' para não");
      }
    }
  }
}
