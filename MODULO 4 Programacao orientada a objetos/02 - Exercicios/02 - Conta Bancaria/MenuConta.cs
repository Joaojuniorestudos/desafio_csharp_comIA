using System.Globalization;

public static class MenuConta
{
  public static void Executar()
  {
    var cultura = CultureInfo.GetCultureInfo("pt-BR");
    Console.Write("Nome do titular: ");
    var titular = (Console.ReadLine() ?? "").Trim();
    if (titular.Length == 0)
      titular = "Cliente";

    Console.Write("Saldo inicial (opcional, Enter = 0): ");
    var saldoTxt = Console.ReadLine();
    decimal saldoInicial = 0;
    if (!string.IsNullOrWhiteSpace(saldoTxt))
      _ = decimal.TryParse(saldoTxt, NumberStyles.Number, cultura, out saldoInicial);

    var conta = new ContaBancaria(titular, saldoInicial);

    while (true)
    {
      Console.WriteLine("\n=== Conta bancária ===");
      Console.WriteLine(conta.Resumo());
      Console.WriteLine("1 - Depositar");
      Console.WriteLine("2 - Sacar");
      Console.WriteLine("0 - Sair");
      Console.Write("Opção: ");
      var op = Console.ReadLine();

      switch (op)
      {
        case "1":
          Console.Write("Valor do depósito: ");
          if (decimal.TryParse(Console.ReadLine(), NumberStyles.Number, cultura, out var dep) && dep > 0)
          {
            conta.Depositar(dep);
            Console.WriteLine("Depósito realizado.");
          }
          else
            Console.WriteLine("Valor inválido.");
          break;
        case "2":
          Console.Write("Valor do saque: ");
          if (decimal.TryParse(Console.ReadLine(), NumberStyles.Number, cultura, out var saq) && saq > 0)
          {
            if (conta.Sacar(saq))
              Console.WriteLine("Saque realizado.");
            else
              Console.WriteLine("Não foi possível sacar (saldo insuficiente ou valor inválido).");
          }
          else
            Console.WriteLine("Valor inválido.");
          break;
        case "0":
          Console.WriteLine("Encerrando.");
          return;
        default:
          Console.WriteLine("Opção inválida.");
          break;
      }
    }
  }
}
