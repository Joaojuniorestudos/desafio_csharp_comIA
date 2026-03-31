List<string> nomes = new List<string>();

nomes.Add("João");
nomes.Add("Maria");
nomes.Add("Carlos");

Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[1]);
Console.WriteLine(nomes[2]);

foreach(string nome in nomes)
{
	Console.WriteLine(nome);
}

// .Contains - para buscar um dado em uma lista: 
if(nomes.Contains("João"))
{
	Console.WriteLine("João encontrado");
}
else
{
	Console.WriteLine("João não encontrado");
}

// .IndexOf - Diferente do Contains ele retorna de forma diferente. Retorna o índice do item.
Console.WriteLine(nomes.IndexOf("João")); // 0
Console.WriteLine(nomes.Contains("João")); // true
Console.WriteLine(nomes.IndexOf("Pedro")); // 2
Console.WriteLine(nomes.Contains("Pedro")); // true
// Também pode ser usado em Arrays