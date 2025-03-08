namespace DesafioPratico
{
  class Exercicio1
  {
    public static void Executar()
    {
      Console.WriteLine("Exercício 1\n");
      Console.WriteLine("Informe seu primeiro nome na linha abaixo:");
      string nome = Console.ReadLine() ?? "Usuário não informado";

      Console.WriteLine($"Olá, {nome}. Seja muito bem-vindo!");
    }
  }
}