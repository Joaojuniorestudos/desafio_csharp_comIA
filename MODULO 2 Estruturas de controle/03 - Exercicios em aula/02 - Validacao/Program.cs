//
for(int i = 1; i <= 3; i++)
{
    Console.WriteLine($"Tentativa {i} de 3");
    Console.WriteLine("Digite o nome do usuário: ");
    string usuario = Console.ReadLine() ??  "";
    Console.WriteLine("Digite a senha: ");
    string senha = Console.ReadLine() ?? "";

    if(usuario == "admin" && senha == "1234")
    {
        Console.WriteLine("Login realizado com sucesso!");
        System.Threading.Thread.Sleep(2000);
        break;
    }
    else
    {
        if(i == 3)
        {
            Console.WriteLine("Limite de tentativas atingido. Encerrando o programa");
            System.Threading.Thread.Sleep(2000);
            break;
        }   

        Console.WriteLine($"Credenciais inválidas. Tentativas restantes: {3 - i}");
        System.Threading.Thread.Sleep(2000);
        Console.Clear();
        continue;
    }

}