Dictionary<string, int> estoque = new Dictionary<string, int>();

while (true)
{
    Console.Clear();
    Console.WriteLine("=== Controle de Estoque ===");
    Console.WriteLine("1 - Cadastrar produto");
    Console.WriteLine("2 - Entrada de estoque");
    Console.WriteLine("3 - Saída de estoque");
    Console.WriteLine("4 - Exibir relatório");
    Console.WriteLine("5 - Sair");
    Console.Write("Escolha uma opção: ");

    int opcao = int.TryParse(Console.ReadLine(), out int op) ? op : 0;

    switch (opcao)
    {
        case 1:
            Console.Write("Produto: ");
            string produtoCadastro = (Console.ReadLine() ?? "").Trim();
            Console.Write("Quantidade inicial: ");

            if (!int.TryParse(Console.ReadLine(), out int qtdInicial) || qtdInicial < 0)
            {
                Console.WriteLine("Quantidade inválida.");
            }
            else if (string.IsNullOrWhiteSpace(produtoCadastro))
            {
                Console.WriteLine("Nome do produto é obrigatório.");
            }
            else
            {
                estoque[produtoCadastro] = qtdInicial;
                Console.WriteLine("Produto cadastrado com sucesso!");
            }
            break;

        case 2:
            Console.Write("Produto para entrada: ");
            string produtoEntrada = (Console.ReadLine() ?? "").Trim();
            Console.Write("Quantidade de entrada: ");

            if (!int.TryParse(Console.ReadLine(), out int qtdEntrada) || qtdEntrada <= 0)
            {
                Console.WriteLine("Quantidade inválida.");
            }
            else if (estoque.ContainsKey(produtoEntrada))
            {
                estoque[produtoEntrada] += qtdEntrada;
                Console.WriteLine("Entrada registrada!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
            break;

        case 3:
            Console.Write("Produto para saída: ");
            string produtoSaida = (Console.ReadLine() ?? "").Trim();
            Console.Write("Quantidade de saída: ");

            if (!int.TryParse(Console.ReadLine(), out int qtdSaida) || qtdSaida <= 0)
            {
                Console.WriteLine("Quantidade inválida.");
            }
            else if (!estoque.ContainsKey(produtoSaida))
            {
                Console.WriteLine("Produto não encontrado.");
            }
            else if (estoque[produtoSaida] < qtdSaida)
            {
                Console.WriteLine("Saída não permitida: estoque insuficiente.");
            }
            else
            {
                estoque[produtoSaida] -= qtdSaida;
                Console.WriteLine("Saída registrada!");
            }
            break;

        case 4:
            if (estoque.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
            }
            else
            {
                Console.WriteLine("--- Relatório de estoque ---");
                foreach (var item in estoque)
                {
                    Console.WriteLine($"Produto: {item.Key} | Quantidade: {item.Value}");
                }
            }
            break;

        case 5:
            Console.WriteLine("Encerrando...");
            return;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    Console.WriteLine("\nPressione Enter para continuar...");
    Console.ReadLine();
}
