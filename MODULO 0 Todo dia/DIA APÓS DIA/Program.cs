/* void executarTabuada()
{
	Console.WriteLine("Digite um número: ");
	int numero = int.Parse(Console.ReadLine());
	for (int i = 1; i <= 10; i++)
	{
		Console.WriteLine($"{numero} x {i} = {numero * i}");
	}
}

void executarCadastro()
{
    List<string> usuarios = new List<string>();
    while(true){
        Console.WriteLine("Digite um nome de usuário: ");
        string nome = Console.ReadLine();
        usuarios.Add(nome);
        Console.WriteLine("Deseja cadastrar outro usuário? (s/n)");
        string resposta = Console.ReadLine() ?? "s"; // para escolher sim como padrão
        if(resposta == "n")
        {
            break;
        }
    }
    Console.WriteLine("Lista de usuários");
    foreach(var usuario in usuarios)
    {
        Console.WriteLine(usuario);
    }
}

void executarMenu()
{
    Console.WriteLine("Menu de opções: ");
    Console.WriteLine("1 - Tabuada");
    Console.WriteLine("2 - Cadastro de usuário e listagem de usuários");
    Console.WriteLine("3 - Verificar número");
    Console.WriteLine("4 - Sair");

    int opcao = int.Parse(Console.ReadLine() ?? "0");
    switch(opcao)
    {
        case 1:
            executarTabuada();
            break;
    }
    case 2:
        executarCadastro();
        break;
    case 3:
        verificarNumero();
        break;
    case 4:
        Console.WriteLine("Saindo do programa...");
        break;
    default:
        Console.WriteLine("Opção inválida!");
        break;
    }
} */


// try{
//     int a = 10;
//     int b = 0;
//     int resultado = a / b;
// }
// catch(Exception ex)
// {
//     Console.WriteLine("Class: " + ex.GetType());
//     Console.WriteLine("Erro: " + ex.Message);
//     Console.WriteLine("StackTrace: " + ex.StackTrace);
// }
// finally
// {
//     Console.WriteLine("Finalizando o programa...");
// }

// FORMAS DE CRIAR UMA LISTA OU ARRAY:

    string[] nomes = 
    [
        "João", 
        "Maria", 
        "Pedro"
    ];

    Console.WriteLine("Velha lista de nomes: ");
    foreach(string nome in nomes){
        Console.WriteLine(nome);
    }

    string[] nomesAtualizado = 
    [
        ..nomes,
        "Gamora"
    ];

    Console.WriteLine("Nova lista de nomes: ");
    foreach(string nome in nomesAtualizado){
        Console.WriteLine(nome);
    }

string[] vogais = ["a", "e", "i", "o", "u"];
string[] alfabeto = [..vogais, "y"];
