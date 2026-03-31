Console.WriteLine("-------Dictionary de alnos string, string ------");

Dictionary <int, string> alunos = new Dictionary<int, string>();

alunos.Add(1, "Danilo");
alunos.Add(2, "João");
alunos.Add(3, "Maria");

foreach(var aluno in alunos)
{
    Console.WriteLine($"ID: {aluno.Key} - Nome: {aluno.Value}");
}

if (alunos.ContainsKey(2))
{
    Console.WriteLine($"Encontrado o alunoa {alunos[2]}");
}

Console.WriteLine("-------Dictionary de nomes string, string ------");

Dictionary<string, string> nomes = new Dictionary<string, string>();
 
nomes.Add("A1", "João");
nomes.Add("A2", "Maria");
nomes.Add("A3", "Carlos");

foreach(var nome in nomes)
{
	Console.WriteLine($"Id: {nome.Key} - Nome: {nome.Value}");
}

if(nomes.ContainsKey("A2"))
{
	Console.WriteLine($"Localizado o nome {nomes["A2"]}");
}

Console.WriteLine("-------Dictionary de clientes string, string ------");

Dictionary<string, string> cliente = new Dictionary<string, string>();
 
cliente.Add("ID", "1");
cliente.Add("Nome", "João");
cliente.Add("Email", "joaojuniorbass@yahoo.com.br");
cliente.Add("Telefone", "21993039776");

Console.WriteLine($"ID: {cliente["ID"]}");
Console.WriteLine($"Nome: {cliente["Nome"]}");
Console.WriteLine($"Email: {cliente["Email"]}");
Console.WriteLine($"Telefone: {cliente["Telefone"]}");

Console.WriteLine("-------Dictionary de clientes string, double ------");

Dictionary<string, double> produtos = new Dictionary<string, double>();
 
produtos.Add("Notebook", 3500.00);
produtos.Add("Mouse", 120.00);
produtos.Add("Teclado", 250.00);

Console.WriteLine(produtos["Notebook"]);