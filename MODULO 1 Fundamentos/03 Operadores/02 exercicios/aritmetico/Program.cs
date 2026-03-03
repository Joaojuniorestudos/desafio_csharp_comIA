/*
Crie um programa que solicite ao usuário dois números inteiros e exiba a soma, 
subtração, multiplicação, divisão e módulo (resto) entre eles.
*/

/*
João é dono de um mercado ele precisa de um programa básico para calcular o valor da venda de seus produtos

Deve receber o nome, preço e quantidade de custo de um produto
calcular o valor total de cada produto e o valor da soma de todos os produtos.

No final deve exibir o valor total de todos os produtos
*/

Console.WriteLine("Olá João bem vindo ao programa");
System.Threading.Thread.Sleep(3000); // para espesrar três segundos



Console.WriteLine("Digite o nome do produto: ");
string nome1 = Console.ReadLine();
Console.WriteLine($"Digite o preço do produto {nome1}");
double preco1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Digite a quantidade do produto {nome1}");
int quantidade1 = int.Parse(Console.ReadLine() ?? "0");
double valorTotal1 = preco1 * quantidade1;
Console.Clear();

Console.WriteLine($"Produto: {nome1}");
Console.WriteLine($"Valor: {preco1}");
Console.WriteLine($"Quantidade: {quantidade1}");
Console.WriteLine($"Valor Total: {valorTotal1.ToString(00.00)}"); // para converter para string e formatar com duas casas decimais




/*
Console.WriteLine("Por favor, digite o nome do produto: ");
nomeProduto = Console.ReadLine();
Console.WriteLine("Por favor, digite o preço de custo do produto: ");
precoCusto = double.Parse(Console.ReadLine());
Console.WriteLine("Por favor, digite a quantidade de produtos: ");
quantidade = int.Parse(Console.ReadLine());

double valorTotal = precoCusto * quantidade;
Console.WriteLine("O valor total do produto " + nomeProduto + " é de R$ " + valorTotal);
*/