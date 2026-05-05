using System.Globalization;

public static class MenuLoja
{
  public static void Executar()
  {
    var loja = new Loja();
    var cultura = CultureInfo.GetCultureInfo("pt-BR");

    while (true)
    {
      Console.WriteLine("\n=== Loja ===");
      Console.WriteLine("1 - Cadastrar produto");
      Console.WriteLine("2 - Listar produtos");
      Console.WriteLine("0 - Sair");
      Console.Write("Opção: ");
      var op = Console.ReadLine();

      switch (op)
      {
        case "1":
          Console.Write("Nome do produto: ");
          var nome = Console.ReadLine() ?? "";
          Console.Write("Preço: ");
          var precoTxt = Console.ReadLine();
          if (decimal.TryParse(precoTxt, NumberStyles.Number, cultura, out var preco))
          {
            loja.Cadastrar(new Produto(nome.Trim(), preco));
            Console.WriteLine("Produto cadastrado.");
          }
          else
            Console.WriteLine("Preço inválido.");
          break;
        case "2":
          loja.ListarNoConsole();
          break;
        case "0":
          Console.WriteLine("Até logo.");
          return;
        default:
          Console.WriteLine("Opção inválida.");
          break;
      }
    }
  }
}
