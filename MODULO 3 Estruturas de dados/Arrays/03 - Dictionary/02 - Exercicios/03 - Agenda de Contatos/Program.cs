Dictionary<string, string> agenda = new Dictionary<string, string>();

while (true)
{
    Console.Clear();
    Console.WriteLine("=== Agenda de Contatos ===");
    Console.WriteLine("1 - Cadastrar contato");
    Console.WriteLine("2 - Buscar contato por nome");
    Console.WriteLine("3 - Listar todos os contatos");
    Console.WriteLine("4 - Sair");
    Console.Write("Escolha uma opção: ");

    int opcao = int.TryParse(Console.ReadLine(), out int op) ? op : 0;

    switch (opcao)
    {
        case 1:
            Console.Write("Nome: ");
            string nome = (Console.ReadLine() ?? "").Trim();
            Console.Write("Telefone: ");
            string telefone = (Console.ReadLine() ?? "").Trim();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(telefone))
            {
                Console.WriteLine("Nome e telefone são obrigatórios.");
            }
            else
            {
                agenda[nome] = telefone;
                Console.WriteLine("Contato cadastrado com sucesso!");
            }
            break;

        case 2:
            Console.Write("Digite o nome para buscar: ");
            string nomeBusca = (Console.ReadLine() ?? "").Trim();

            if (agenda.TryGetValue(nomeBusca, out string? telefoneEncontrado))
            {
                Console.WriteLine($"Contato encontrado: {nomeBusca} -> {telefoneEncontrado}");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
            break;

        case 3:
            if (agenda.Count == 0)
            {
                Console.WriteLine("Nenhum contato cadastrado.");
            }
            else
            {
                Console.WriteLine("--- Lista de contatos ---");
                foreach (var contato in agenda)
                {
                    Console.WriteLine($"Nome: {contato.Key} | Telefone: {contato.Value}");
                }
            }
            break;

        case 4:
            Console.WriteLine("Encerrando...");
            return;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    Console.WriteLine("\nPressione Enter para continuar...");
    Console.ReadLine();
}
