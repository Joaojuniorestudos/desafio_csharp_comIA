List<int> numeros = new List<int> {5, 10, 15, 20, 25};
var resultado = numeros
	.Where(n => n > 10)
    .Where(n => n < 20)
	.OrderBy(n => n)
	.Select(n => n * 2);
foreach(var n in resultado)
{
	Console.WriteLine(n);
}

// uso cimplificado
var resultado2 = from n in numeros
	where n > 10 // filtrando n maior que 10
	where n < 20 // filtrando n menor que 20
	orderby n // ordenando n em ordem crescente
	select n * 2; // Multiplicando por 2
foreach(var n in resultado2)
{
	Console.WriteLine($"Resultado 2: {n}");
}


Console.WriteLine("------- Exemplo com pais e filhos -----");
var pais = new List<(string Nome, int Idade, List<(string Nome, int Idade)> Filhos)>() 
{
	(	"Carlos", 
		45, 
		new List<(string, int)>
		{
			("Ana", 20),
			("João", 18)
		}
	), 
	(
		"Maria", 
		40, 
		new List<(string, int)>
		{
			("Paulo", 15),
			("Fernanda", 12)
		}
	),
	(
		"Roberto", 
		52, 
		new List<(string, int)>
		{
			("Rodolpho", 21)
		}
	)
};

Console.WriteLine("----- Exemplo de exibição dos dados -----");
foreach(var pai in pais)
{
	Console.WriteLine($"Pai/Mãe: {pai.Nome} - Idade: {pai.Idade}");
	Console.WriteLine("Filhos: ");
	foreach(var f in pai.Filhos)
	{
		Console.WriteLine($"Nome: {f.Nome} - Idade {f.Idade}");
	}
}

Console.WriteLine("----- Exemplo de filtragem de pais, filhos e -----");
// para somar a idade de todos os pais:
var idadesPaisSomadas = pais.Select(p => p.Idade).Sum();
Console.WriteLine($"Idades dos pais somadas: {idadesPaisSomadas}");

Console.WriteLine("----- Exemplo de filtragem de pais, like SQL -----");
// para somar a idade de todos os pais mas usando o like SQL:
var idadesPaisSomadas2 = (from p in pais select p.Idade).Sum();
Console.WriteLine($"Idades dos pais somadas: {idadesPaisSomadas}");

Console.WriteLine("----- Exemplo de filtragem de filhos -----");
// para somar a idade de todos os filhos
var idadesFilhosSomadas1 = pais.Select(p => p.Filhos.Select(f => f.Idade).Sum()).Sum();
Console.WriteLine($"Idades dos filhos somadas: {idadesFilhosSomadas1}");

Console.WriteLine("----- Exemplo de filtragem de filhos, like SQL -----");
// para somar a idade de todos os pais mas usando o like SQL:
var idadesFilhosSomadas2 = (from pai in pais select pai.Filhos.Select(filho => filho.Idade).Sum()).Sum();
Console.WriteLine($"Idades dos filhos somadas: {idadesFilhosSomadas2}");

Console.WriteLine("----- Exemplo de filtragem de filhos, like SQL MAXIMU-----");
var idadeFilhosSomads3 = (
	from p in pais
	from f in p.Filhos
	select f.Idade
).Sum();
Console.WriteLine($"Idades dos filhos somadas: {idadeFilhosSomads3}");

// Exemplo soma de filhos agrupados por pai
Console.WriteLine("\n--- Exemplo de soma de idade dos fihos ---");
var idadeFilhosSomadosAgrupadosPorPai = 
	pais.Select(p => new
	{
		Nome = p.Nome,
		SomaIdadeFilhos = p.Filhos.Sum(f => f.Idade)
	});
foreach(var item in idadeFilhosSomadosAgrupadosPorPai)
{
	Console.WriteLine($"Pai: {item.Nome} - Idade total dos filhos {item.SomaIdadeFilhos}");
}

// Exemplo com LIKE SQL
var idadeFilhosSomadosAgrupadosPorPaiSQL = (
    from p in pais
    from f in p.Filhos
    group f by p.Nome into g
    select new
    {
        Nome = g.Key,
        SomaIdadeFilhos = g.Sum(f => f.Idade)
    }
);
foreach(var item in idadeFilhosSomadosAgrupadosPorPaiSQL)
{
    Console.WriteLine($"Pai/Mãe: {item.Nome} - Idade filho {item.SomaIdadeFilhos}");
}

// EXEMPLO COM JOIN:
Console.WriteLine("\n---- Exemplo Like SQ com Join ----");
var filhosSeparados = new List<dynamic>
{
	new {Id = 1, Nome = "Lucas", Idade = 10, PaiId = 1},
	new {Id = 2, Nome = "Julia", Idade = 8, PaiId = 1},
	new {Id = 3, Nome = "Pedro", Idade = 12, PaiId = 2},
	new {Id = 4, Nome = "Ana", Idade = 9, PaiId = 2},
	new {Id = 5, Nome = "Carlos", Idade = 7, PaiId = 3}
};

var paisDosFilhos = new List<dynamic>
{
	new {Id = 1, Nome = "Carlos", Idade = 45},
	new {Id = 2, Nome = "Mari", Idade = 43},
	new {Id = 3, Nome = "Pedro", Idade = 50}
};

// esse é o exemplo usando Join e like sql:
var consultaJoin = 
	from pai in paisDosFilhos
	join filho in filhosSeparados
	on pai.Id equals filho.PaiId
	select new
	{
		PaiNome = pai.Nome,
		PaiIdade = pai.Idade,
		FilhoNome = filho.Nome,
		FilhoIdade = filho.Idade
	};
// exibindo em formato tabela (agora incluindo idade do pai)
Console.WriteLine("{0, -10} | {1, -10} | {2, -15} | {3, -15}", "Pai", "Idade Pai", "Filho", "Idade Filho");
Console.WriteLine(new string('-', 60));
foreach(var item in consultaJoin)
{
	Console.WriteLine("{0, -10} | {1, -10} | {2, -15} | {3, -15}", item.PaiNome, item.PaiIdade, item.FilhoNome, item.FilhoIdade);
}
