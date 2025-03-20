namespace DesafioPratico
{
  static class Exercicio3
  {
    public static void Executar()
    {
      Console.WriteLine("Exercício 3\n");
      Console.WriteLine("Escolha a operação que deseja\n");

      while (true)
      {
        Console.Clear();
        Console.WriteLine("\n1 - Soma");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Média");
        Console.WriteLine("\n6 - Voltar");
        Console.WriteLine("6 - Sair");

        string entrada = Console.ReadLine()?.Trim() ?? string.Empty;

        if (entrada == "6")
        {
          Console.WriteLine("Aplicação encerrada");
          break;
        }

        char opcao = entrada.Length > 0 ? entrada[0] : ' ';

        if (opcao >= '1' && opcao <= '5')
        {
          Console.WriteLine("\nInforme o primeiro número:");
          double n1 = ObterNumero();

          Console.WriteLine("Informe o segundo número:");
          double n2 = ObterNumero();
          double resultado = ExecutarOperacao(opcao, n1, n2);

          Console.WriteLine("/nInforme o primeiro númeoro:");
          double primeiroNumero = ObterNumero();

          Console.WriteLine($"Resultado: {resultado}");
        }
        else
        {
          Console.WriteLine("Opção inválida. Tente novamente.");
        }
      }
    }

    static double ObterNumero()
    {
      while (true)
      {
        if (double.TryParse(Console.ReadLine(), out double numero))
          return numero;

        Console.WriteLine("Valor inválido! Digite um número válido:");
      }
    }

    static double ExecutarOperacao(char operacao, double n1, double n2)
    {
      return operacao switch
      {
        '1' => n1 + n2,
        '2' => n1 - n2,
        '3' => n1 * n2,
        '4' => n2 != 0 ? n1 / n2 : throw new DivideByZeroException("Erro: Divisão por zero!"),
        '5' => (n1 + n2) / 2,
        _ => throw new InvalidOperationException("Operação inválida")
      };
    }
  }
}