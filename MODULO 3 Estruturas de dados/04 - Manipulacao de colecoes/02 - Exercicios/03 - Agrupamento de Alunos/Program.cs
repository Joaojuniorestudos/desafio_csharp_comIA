// EXERCÍCIO 03 — Agrupamento de Alunos por Letra (SEM LINQ)
//
// Objetivo:
// - Recriar a ideia do GroupBy do exemplo, mas usando Dictionary + loops.
//
// Regras:
// - NÃO use LINQ.
//
// Tarefas:
// 1) Dada a lista de nomes, agrupar por letra inicial (case-insensitive).
// 2) Em cada grupo:
//    - Mostrar a letra
//    - Mostrar os nomes do grupo (string.Join)
// 3) Extra:
//    - Ordenar as chaves (letras) em ordem alfabética (sem LINQ)
//    - Ordenar os nomes dentro de cada grupo (sem LINQ)

var alunos = new List<string>
{
  "Ana",
  "José",
  "Pedro",
  "João",
  "Beatriz",
  "bruno",
  "aline",
  "juliana",
};

// 1) Agrupar por letra inicial
var grupos = new Dictionary<char, List<string>>();

foreach (var nome in alunos)
{
  if (string.IsNullOrWhiteSpace(nome))
    continue;

  var inicial = char.ToUpperInvariant(nome.Trim()[0]);

  if (!grupos.TryGetValue(inicial, out var lista))
  {
    lista = new List<string>();
    grupos[inicial] = lista;
  }

  lista.Add(nome.Trim());
}

// 2) Ordenar as letras (chaves) sem LINQ
var letras = new List<char>();
foreach (var kv in grupos)
  letras.Add(kv.Key);

letras.Sort(); // ordem alfabética

Console.WriteLine("------------- Agrupamento (sem LINQ) ---------------");
foreach (var letra in letras)
{
  var nomesDoGrupo = grupos[letra];
  nomesDoGrupo.Sort(StringComparer.CurrentCultureIgnoreCase); // 3) ordenar nomes do grupo

  Console.WriteLine($"Letra: {letra}");
  Console.WriteLine($"Nomes: {string.Join(", ", nomesDoGrupo)}");
  Console.WriteLine();
}

