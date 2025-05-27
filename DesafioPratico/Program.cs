namespace DesafioPratico
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
				{
					Console.WriteLine("Tem ceteza que deseja sair ? (S/N)");
					string confirmar = Console.ReadLine()?.Trim().ToUpper() ?? "";

					if (confirmar == "S")
					{
						Console.WriteLine("Aplicação encerrada.");
						break;
					}
					else
					{
						Console.WriteLine("Voltando ao menu...");
						continue;
					}
				}

				if (!ExecutarDesafio(desafio))
				{
					Console.WriteLine("\nDesafio não encontrado! Tente novamente");
					Console.WriteLine("Presione Enter para continuar...");
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
			Console.WriteLine("Desafio Prático RocketSeat\n");
			Console.WriteLine("Seleione uma das opções abaixo:\n");
			Console.WriteLine("1 Seu nome - OK");
			Console.WriteLine("2 Nome e sobrenome - OK");
			Console.WriteLine("3 Calculadora - OK");
			Console.WriteLine("4 Contador de Caracteres - OK");
			Console.WriteLine("5 Validador de placa - OK");
			Console.WriteLine("6 Data Atual (Formatos)\n");
			Console.WriteLine("(E) Exit");
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
