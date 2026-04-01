List<int> numeros = new List<int>{10, 20, 40, 6, 8};

Console.WriteLine("-------------Where---------------");
var maioresQue10 = numeros.Where(n => n > 10); //

foreach(var numero in maioresQue10)
{
	Console.WriteLine(numero); // pra mostrar os números
	
}

Console.WriteLine("-------------Maiores que 15---------------");
Console.WriteLine("Maiores são: " + string.Join(", ", maioresQue10)); // pra mostrar em uma única string

List<int> numerosMaioresQue15 = numeros.Where(n => n >15).ToList();
foreach(var numero in numerosMaioresQue15)
{
	Console.WriteLine(numero);
}
Console.WriteLine("Maiores são: " + string.Join(", ", numerosMaioresQue15)); // pra mostrar em uma única string

Console.WriteLine("-------------OrderBy ascendente---------------");
var ordenados = numeros.OrderBy(n => n);
foreach(var numero in ordenados)
{
	Console.WriteLine(numero);
}

Console.WriteLine("-------------OrderBy descendente---------------");
var ordenadosDescendente = numeros.OrderByDescending(n => n);
foreach(var numero in ordenadosDescendente)
{
	Console.WriteLine(numero);
}
Console.WriteLine("------------------------------------------------");

Console.WriteLine("-------------Transformar dados (Select)---------------");
var transformados = numeros.Select(n => n * 2);
Console.WriteLine("Transformados: " + string.Join(", ", transformados));

Console.WriteLine("------------- Transforma dados (Select) 2---------------");
List<string> nomes = new List<string>{ "joão", "maria", "josé"};
var transformadosNomesUpper = nomes.Select(n => n.ToUpper());
Console.WriteLine("Transformados Maiúsculos: " + string.Join(", ", transformadosNomesUpper));

Console.WriteLine("------------- Transforma dados (Select) 3---------------");
List<string> nomes2 = new List<string>{"JOão", "MARIA", "JOsÉ"};
var transformadoNomesLow = nomes2.Select(n => n.ToLower());
Console.WriteLine("Transformados Minúsculos: " + string.Join(", ", transformadoNomesLow));

Console.WriteLine("------------- Retorna o primeiro---------------");
List<int> numeros2 = new List<int>{10, 0, 20, 30, 40};
int primeiro = numeros2.First();
Console.WriteLine($"Primeiro da lista: {primeiro}");


Console.WriteLine("------------- Retorna o primeiro---------------");
List<int> numeros3 = new List<int>{10, 0, 20, 30, 40};
int encontrado = numeros3.First(n => n > 25);
Console.WriteLine($"Primeiro acima de 25: {encontrado}");

Console.WriteLine("------------- Verifica se existe na lista---------------");
List<int> numeros4 = new List<int>{33, 45, 30, 10, 50};
Console.WriteLine("Lista completa: " + string.Join(", ", numeros4));
bool existe = numeros4.Contains(45);
Console.WriteLine($"O elemento 45 existe na lista: {existe}");

existe = numeros4.Contains(68);
Console.WriteLine($"O elemento 68 existe na lista: {existe}");

Console.WriteLine("------------- Verifica a quantidade lista---------------");
List<int> numeros5 = new List<int>{33, 45, 30, 10, 50};
int quantidade = numeros5.Count; // não usa delegate
Console.WriteLine($"Quantidade de itens: {quantidade}");
quantidade = numeros5.Count(n => n > 30); // usa delegate
Console.WriteLine($"Quantidade de itens: {quantidade}"); 

Console.WriteLine("------------- Agrupando elementos lista---------------");
List<string> nomesAgrupar = new List<string>{"Ana", "José", "Pedro", "João", "Beatriz"};
var grupos = nomesAgrupar.GroupBy(n => n[0]);
foreach(var grupo in grupos)
{
	Console.WriteLine($"Letra: {grupo.Key}");
	foreach(var nome in grupo)
	{
		Console.WriteLine($"Nome: {nome}");
	}
}

// exemplo com join
Console.WriteLine("------------- Agrupando elementos lista com join---------------");
foreach(var grupo in grupos)
{
	Console.WriteLine($"Letra: {grupo.Key}");
	var nomesAgrupados = string.Join(", ", grupo);
	Console.WriteLine($"Nomes: {nomesAgrupados}");

}
