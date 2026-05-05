// Guarda e consulta livros.
public class Biblioteca
{
  private readonly List<Livro> _livros = new();

  public void Adicionar(Livro livro)
  {
    _livros.Add(livro);
  }

  public void ListarNoConsole()
  {
    Console.WriteLine("\n--- Acervo ---");
    if (_livros.Count == 0)
    {
      Console.WriteLine("Nenhum livro.");
      return;
    }

    for (int i = 0; i < _livros.Count; i++)
      Console.WriteLine($"{i + 1}. {_livros[i]}");
  }

  // Primeiro livro cujo título contém o termo (ignore case).
  public Livro? BuscarPorTituloContem(string termo)
  {
    if (string.IsNullOrWhiteSpace(termo))
      return null;

    foreach (var l in _livros)
    {
      if (l.Titulo.Contains(termo, StringComparison.CurrentCultureIgnoreCase))
        return l;
    }

    return null;
  }

  // TODO (aluno): RemoverPorTitulo(string titulo) com comparação ignore case
}
