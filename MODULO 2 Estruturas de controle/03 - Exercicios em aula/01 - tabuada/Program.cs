/*
Console.WriteLine("Digite um número para ver a tabuada: ");
string entrada = Console.ReadLine() ?? "";

if (int.TryParse(entrada, out int numero))
{
    Console.WriteLine($"\nTabuada do {numero}:\n");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{numero} x {i} = {numero * i}");
    }
}
else
{
    Console.WriteLine("Entrada inválida. Digite um número inteiro.");
}
*/

// meu exercício
/*
while(true){
    Console.WriteLine("Digite um número inteiro: ");
    int numero = 0;
    if(int.TryParse(Console.ReadLine() ?? "0", out numero))
    {
        Console.WriteLine("Encerrando...");
        break;
    }

    Console.WriteLine("Número inválido, tente novamente");
    System.Threading.Thread.Sleep(2500);
    Console.Clear();
 }
*/
 // Parei aos 00:19:16


 while(true)
{
    Console.WriteLine("Digite um número inteiro para ver a tabuada: ");
    int numero = 0;

    if(int.TryParse(Console.ReadLine() ?? "0", out numero))
    {
        Console.Clear();
        if(numero < 1 || numero > 10)
        {
            Console.WriteLine("Número inválido");
            System.Threading.Thread.Sleep(1800);
            Console.Clear();
            continue;
        }
        else
        {
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine($"{numero} X {i} = {numero * i}");
            }
            break;
        }
    }
}