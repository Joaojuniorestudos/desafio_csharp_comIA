using System.Globalization;

// Lista e operações sobre produtos.
public class Loja
{
  private readonly List<Produto> _produtos = new();

  public IReadOnlyList<Produto> Produtos => _produtos;

  public void Cadastrar(Produto produto)
  {
    _produtos.Add(produto);
  }

  public void ListarNoConsole()
  {
    Console.WriteLine("\n--- Produtos cadastrados ---");
    if (_produtos.Count == 0)
    {
      Console.WriteLine("Nenhum produto.");
      return;
    }

    var cultura = CultureInfo.GetCultureInfo("pt-BR");
    for (int i = 0; i < _produtos.Count; i++)
    {
      var p = _produtos[i];
      Console.WriteLine($"{i + 1}. {p.Nome} — {p.Preco.ToString("C", cultura)}");
    }
  }

  // TODO (aluno): implementar remoção pelo nome e usar no MenuLoja.
  // public bool RemoverPorNome(string nome) { ... }
}
