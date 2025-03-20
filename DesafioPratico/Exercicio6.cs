using System.Globalization;

namespace DesafioPratico
{
  static class Exercicio6
  {
    public static void Executar()
    {
      Console.WriteLine("Exercício 6\n");

      Console.WriteLine("Selecione o formato que deseja exibir os dados:\n");
      Console.WriteLine("1 \u25B6 Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
      Console.WriteLine("2 \u25B6 Apenas a data no formato \"DD/MM/AAAA\"");
      Console.WriteLine("3 \u25B6 Apenas a hora no formato de 24 horas");
      Console.WriteLine("4 \u25B6 A data com o mês por extenso\n");

      string selecionado = Console.ReadLine()?.Trim() ?? string.Empty;
      DateTime dataAtual = DateTime.Now;

      string diaSemana = dataAtual.ToString("dddd", new CultureInfo("pt-BR"));
      string diaSemanaUper = char.ToUpper(diaSemana[0]) + diaSemana.Substring(1);
      string dataFormatada = dataAtual.ToString("dd/MM/yyyy HH:mm:ss", new CultureInfo("pt-BR"));

      if (selecionado == "1")
      {
        Console.WriteLine(string.Format("\nO formato selecionado foi:\n {0}, {1}", diaSemanaUper, dataFormatada));
      }
    }
  }
}