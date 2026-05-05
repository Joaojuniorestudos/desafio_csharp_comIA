class Algoritmos
{
    // tabuada
    public static void executarTabuada()
    {
        Console.Write("Digite um número para ver a tabuada: ");
        string entrada = Console.ReadLine() ?? "";
        if (int.TryParse(entrada, out int numero))
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
        else
        {
            Console.WriteLine("Número inválido!");
        }
    }

    // captura de números
    public static void executarCapturaNumero()
    {
        Console.Write("Digite um número: ");
        string resposta = Console.ReadLine() ?? "";
        if (int.TryParse(resposta, out int numero))
        {
            Console.WriteLine($"Você digitou o número {numero}");
        }
        else
        {
            Console.WriteLine("Valor inválido! Digite um número válido.");
        }
    }

    // cadastro
    public static void executarCadastro(List<(string Nome, int Idade, string Email)> usuarios)
    {
        Console.WriteLine("\n--- Cadastro de Usuário ---");
        Console.Write("Digite o nome do usuário: ");
        string nome = Console.ReadLine() ?? "";

        Console.Write("Digite a idade do usuário: ");
        string idadeInput = Console.ReadLine() ?? "";
        int idadeUsuario;
        while (!int.TryParse(idadeInput, out idadeUsuario) || idadeUsuario < 0)
        {
            Console.Write("Idade inválida. Digite novamente a idade do usuário: ");
            idadeInput = Console.ReadLine() ?? "";
        }

        Console.Write("Digite o e-mail do usuário: ");
        string email = Console.ReadLine() ?? "";

        usuarios.Add((nome, idadeUsuario, email));
        Console.WriteLine($"\nUsuário cadastrado:\nNome: {nome}\nIdade: {idadeUsuario}\nEmail: {email}");
    }

    public static void menuUsuarios(List<(string Nome, int Idade, string Email)> usuarios)
    {
        string opcao = "";
        while (opcao != "0")
        {
            Console.WriteLine("\n--- Menu de Usuários ---");
            Console.WriteLine("1 - Cadastrar novo usuário");
            Console.WriteLine("2 - Listar usuários cadastrados");
            Console.WriteLine("0 - Voltar ao menu principal");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine() ?? "";

            switch (opcao)
            {
                case "1":
                    executarCadastro(usuarios);
                    break;
                case "2":
                    Console.WriteLine("\n--- Lista de Usuários Cadastrados ---");
                    if (usuarios.Count == 0)
                    {
                        Console.WriteLine("Nenhum usuário cadastrado.");
                    }
                    else
                    {
                        foreach (var usuario in usuarios)
                        {
                            Console.WriteLine($"Nome: {usuario.Nome} | Idade: {usuario.Idade} | Email: {usuario.Email}");
                        }
                    }
                    break;
                case "0":
                    Console.WriteLine("Voltando ao menu principal...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}