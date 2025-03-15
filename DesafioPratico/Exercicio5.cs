using System.Text.RegularExpressions;

namespace DesafioPratico
{
  static class Exercicio5
  {
    public static void Executar()
    {
      Console.WriteLine("Exercício 5\n");
      string placa;

      do
      {
        Console.Write("Digite a placa do veículo");
        placa = Console.ReadLine()?.ToUpper().Trim() ?? "";

        if (string.IsNullOrEmpty(placa))
        {
          Console.WriteLine("A placa não pode ser vazia. Tente novamente.");
        }
      } while (string.IsNullOrEmpty(placa));

      if (ValidaPlacaAntiga(placa))
        Console.WriteLine("O formato da placa é valido.");
      else
        Console.WriteLine("O formato da placa não é válido.");
    }

    static bool ValidaPlacaAntiga(string placa)
    {
      string formato = @"^[A-Z]{3}-\d{4}$";
      return Regex.IsMatch(placa, formato);
    }
  }
}