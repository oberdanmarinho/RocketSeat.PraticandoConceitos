namespace DesafioPratico
{
  static class Exercicio4
  {
    public static void Executar()
    {
      Console.WriteLine("Exercício 4\n");
      Console.WriteLine("Digite uma palavra ou uma frase:");
      string palavraDigitada = Console.ReadLine()?.Trim() ?? string.Empty;
      string tipo = palavraDigitada.Contains(" ") ? "frase" : "palavra";

      Console.WriteLine($"A {tipo} '{palavraDigitada}', possui {palavraDigitada.Length} caracteres");
    }
  }
}