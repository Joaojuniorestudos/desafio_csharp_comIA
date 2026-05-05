public static class MenuBiblioteca
{
  public static void Executar()
  {
    var bib = new Biblioteca();

    while (true)
    {
      Console.WriteLine("\n=== Biblioteca ===");
      Console.WriteLine("1 - Cadastrar livro");
      Console.WriteLine("2 - Listar livros");
      Console.WriteLine("3 - Buscar por trecho do título");
      Console.WriteLine("0 - Sair");
      Console.Write("Opção: ");
      var op = Console.ReadLine();

      switch (op)
      {
        case "1":
          Console.Write("Título: ");
          var titulo = Console.ReadLine() ?? "";
          Console.Write("Autor: ");
          var autor = Console.ReadLine() ?? "";
          Console.Write("Ano: ");
          if (int.TryParse(Console.ReadLine(), out var ano))
          {
            bib.Adicionar(new Livro(titulo.Trim(), autor.Trim(), ano));
            Console.WriteLine("Livro cadastrado.");
          }
          else
            Console.WriteLine("Ano inválido.");
          break;
        case "2":
          bib.ListarNoConsole();
          break;
        case "3":
          Console.Write("Trecho do título: ");
          var termo = Console.ReadLine() ?? "";
          var achado = bib.BuscarPorTituloContem(termo);
          if (achado is null)
            Console.WriteLine("Nenhum livro encontrado.");
          else
            Console.WriteLine($"Encontrado: {achado}");
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
