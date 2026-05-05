using static Algoritmos;

class Menu
{

    public static void menuPrincipal()
    {
        List<(string Nome, int Idade, string Email)> usuarios = new List<(string, int, string)>();
        while (true)
        {
            Console.WriteLine("\n=== Menu Principal ===");
            Console.WriteLine("1 - Ver tabuada");
            Console.WriteLine("2 - Gerenciar usuários");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcaoMenu = Console.ReadLine();

            switch (opcaoMenu)
            {
                case "1":   
                    Algoritmos.executarTabuada();
                    break;
                case "2":
                    Algoritmos.menuUsuarios(usuarios);
                    break;
                case "0":
                    Console.WriteLine("Saindo do programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
