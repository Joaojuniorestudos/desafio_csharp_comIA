// EXERCÍCIO 02 — Gerenciador de Tarefas (SEM LINQ)
//
// Objetivo:
// - Praticar List<T>, loops, condições, busca manual e menus no Console.
//
// Regras:
// - NÃO use LINQ.
//
// Tarefas:
// 1) Mostrar um menu em loop:
//    1 - Adicionar tarefa
//    2 - Listar tarefas
//    3 - Marcar como concluída (por número)
//    4 - Remover tarefa (por número)
//    5 - Buscar por palavra (no título) (sem LINQ)
//    0 - Sair
// 2) Uma tarefa tem: Titulo (string) e Concluida (bool)
// 3) Na listagem, mostrar: "1) [ ] Estudar C#" ou "2) [x] Estudar C#"

record Tarefa(string Titulo, bool Concluida);

internal static class Program
{
  private static void Main()
  {
    var tarefas = new List<Tarefa>
    {
      new("Revisar List<T>", false),
      new("Fazer exercícios", false),
      new("Praticar loops", true),
    };

    while (true)
    {
      MostrarMenu();
      var opcao = (Console.ReadLine() ?? "").Trim();

      if (opcao == "0")
        break;

      if (opcao == "1")
      {
        var titulo = LerTexto("Título: ");
        tarefas.Add(new Tarefa(titulo, false));
        Console.WriteLine("Tarefa adicionada.");
      }
      else if (opcao == "2")
      {
        Listar(tarefas);
      }
      else if (opcao == "3")
      {
        Listar(tarefas);
        var n = LerNumero("Número da tarefa para concluir: ");
        var idx = n - 1;
        if (idx < 0 || idx >= tarefas.Count)
        {
          Console.WriteLine("Número fora do intervalo.");
          continue;
        }

        var atual = tarefas[idx];
        tarefas[idx] = atual with { Concluida = true };
        Console.WriteLine("Tarefa marcada como concluída.");
      }
      else if (opcao == "4")
      {
        Listar(tarefas);
        var n = LerNumero("Número da tarefa para remover: ");
        var idx = n - 1;
        if (idx < 0 || idx >= tarefas.Count)
        {
          Console.WriteLine("Número fora do intervalo.");
          continue;
        }

        tarefas.RemoveAt(idx);
        Console.WriteLine("Tarefa removida.");
      }
      else if (opcao == "5")
      {
        var termo = LerTexto("Buscar por: ");
        Console.WriteLine();
        Console.WriteLine("------------- RESULTADOS -------------");

        bool encontrou = false;
        for (int i = 0; i < tarefas.Count; i++)
        {
          var t = tarefas[i];
          if (t.Titulo.Contains(termo, StringComparison.CurrentCultureIgnoreCase))
          {
            var status = t.Concluida ? "x" : " ";
            Console.WriteLine($"{i + 1}) [{status}] {t.Titulo}");
            encontrou = true;
          }
        }

        if (!encontrou)
          Console.WriteLine("Nenhuma tarefa encontrada.");
      }
      else
      {
        Console.WriteLine("Opção inválida.");
      }
    }

    Console.WriteLine("Saindo...");
  }

  private static void MostrarMenu()
  {
    Console.WriteLine();
    Console.WriteLine("------------- MENU -------------");
    Console.WriteLine("1 - Adicionar tarefa");
    Console.WriteLine("2 - Listar tarefas");
    Console.WriteLine("3 - Marcar como concluída (por número)");
    Console.WriteLine("4 - Remover tarefa (por número)");
    Console.WriteLine("5 - Buscar por palavra");
    Console.WriteLine("0 - Sair");
    Console.Write("Opção: ");
  }

  private static void Listar(List<Tarefa> tarefas)
  {
    Console.WriteLine();
    Console.WriteLine("------------- TAREFAS -------------");
    if (tarefas.Count == 0)
    {
      Console.WriteLine("Nenhuma tarefa cadastrada.");
      return;
    }

    for (int i = 0; i < tarefas.Count; i++)
    {
      var t = tarefas[i];
      var status = t.Concluida ? "x" : " ";
      Console.WriteLine($"{i + 1}) [{status}] {t.Titulo}");
    }
  }

  private static int LerNumero(string label)
  {
    while (true)
    {
      Console.Write(label);
      var texto = Console.ReadLine();
      if (int.TryParse(texto, out var numero))
        return numero;
      Console.WriteLine("Número inválido. Tente novamente.");
    }
  }

  private static string LerTexto(string label)
  {
    while (true)
    {
      Console.Write(label);
      var texto = (Console.ReadLine() ?? "").Trim();
      if (texto.Length > 0)
        return texto;
      Console.WriteLine("Texto vazio. Tente novamente.");
    }
  }
}

