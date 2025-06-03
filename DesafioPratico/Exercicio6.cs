using System.Globalization;

namespace DesafioPratico
{
  static class Exercicio6
  {
    public static void Executar()
    {
      Console.Clear();
      Console.WriteLine("Exercício 6\n");
      Console.WriteLine("Selecione o formato que deseja exibir os dados:\n");

      CultureInfo cultura = new CultureInfo("pt-BR");

      while (true)
      {
        Console.WriteLine("\n1 \u25B6 Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2 \u25B6 Apenas a data no formato \"DD/MM/AAAA\"");
        Console.WriteLine("3 \u25B6 Apenas a hora no formato de 24 horas");
        Console.WriteLine("4 \u25B6 A data com o mês por extenso\n");
        Console.WriteLine("5 \u25B6 Encerrar\n");

        DateTime dataAtual = DateTime.Now;
        string selecionado = Console.ReadLine()?.Trim() ?? string.Empty;


        switch (selecionado)
        {
          case "1":
            {
              string diaSemana = dataAtual.ToString("dddd", cultura);
              string diaSemanaCapitalizado = cultura.TextInfo.ToTitleCase(diaSemana); ;
              string dataFormatada = dataAtual.ToString("dd/MM/yyyy HH:mm:ss", cultura);

              Console.WriteLine($"\nO formato selecionado foi:\n {diaSemanaCapitalizado}, {dataFormatada}");
              break;
            }
          case "2":
            Console.WriteLine($"\nO formato selecionado foi:\n {dataAtual.ToString("d", cultura)}");
            break;
          case "3":
            Console.WriteLine($"\nO formato selecionaod foi:\n {dataAtual.ToString("t" + ".", cultura)}");
            break;
          case "4":
            Console.WriteLine($"\nO formato selecionado foi:\n {dataAtual.ToString("dd 'de'  MMMM 'de' yyyy '.'", cultura)}");
            break;
          case "5":
            Console.WriteLine("Aplicação encerrada");
            return;

          default:
            Console.WriteLine("Opção inválida. Tente novamente");
            break;
        }
      }
    }
  }
}