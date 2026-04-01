// EXERCÍCIO 01 — Filtro e Ordenação de Produtos (SEM LINQ)
//
// Objetivo:
// - Praticar manipulação de coleções usando List<T>, loops, if, Sort e string.Join.
//
// Regras:
// - NÃO use LINQ (Where/Select/OrderBy/GroupBy/First/Any/etc).
//
// Tarefas:
// 1) Filtrar somente produtos com preço > 50.
// 2) Ordenar esses produtos filtrados por preço (crescente).
// 3) Gerar uma lista apenas com os nomes (em maiúsculo) desses produtos filtrados.
// 4) Exibir:
//    - Lista original (nome - preço)
//    - Lista filtrada e ordenada (nome - preço)
//    - Nomes em maiúsculo (string.Join)

using System.Globalization;

static string FormatPrice(decimal price)
  => price.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));

var produtos = new List<(string Nome, decimal Preco)>
{
  ("Mouse", 49.90m),
  ("Teclado", 129.99m),
  ("Monitor", 899.00m),
  ("Cabo HDMI", 35.00m),
  ("Headset", 199.90m),
  ("Webcam", 79.90m),
};

Console.WriteLine("------------- Lista original ---------------");
for (int i = 0; i < produtos.Count; i++)
{
  var p = produtos[i];
  Console.WriteLine($"{i + 1}. {p.Nome} - {FormatPrice(p.Preco)}");
}

// 1) Filtrar preço > 50 (sem LINQ)
var filtrados = new List<(string Nome, decimal Preco)>();
foreach (var p in produtos)
{
  if (p.Preco > 50m)
    filtrados.Add(p);
}

// 2) Ordenar por preço (crescente) (sem LINQ)
filtrados.Sort((a, b) => a.Preco.CompareTo(b.Preco));

Console.WriteLine();
Console.WriteLine("------------- Filtrados (preço > 50) e ordenados ---------------");
for (int i = 0; i < filtrados.Count; i++)
{
  var p = filtrados[i];
  Console.WriteLine($"{i + 1}. {p.Nome} - {FormatPrice(p.Preco)}");
}

// 3) Lista só de nomes em maiúsculo (sem LINQ)
var nomesMaiusculos = new List<string>();
foreach (var p in filtrados)
{
  nomesMaiusculos.Add(p.Nome.ToUpperInvariant());
}

Console.WriteLine();
Console.WriteLine("------------- Nomes em maiúsculo (filtrados) ---------------");
Console.WriteLine(string.Join(", ", nomesMaiusculos));

