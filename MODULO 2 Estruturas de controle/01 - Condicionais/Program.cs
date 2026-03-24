Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine() ?? "0");

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade");
} 
else
{
    Console.WriteLine("Você é menor de idade");
}

// Exemplo com IF, ELSE IF e ELSE
Console.WriteLine("Fases de uma pessoa \nDigite sua idade: ");
int idade3 = int.Parse(Console.ReadLine() ?? "0");

if (idade3 >= 18)
{
	Console.WriteLine("Você já é adulto");
}
else if (idade3 >= 14)
{
	Console.WriteLine("Você é adolescente");
}
else
{
	Console.WriteLine("Você é criança");
} 

// ESTRUTURA COM SWITCH:
int dia = 2;

switch(dia)
{
    case 1:
        Console.WriteLine("É Domingo");
        break;
    case 2:
        Console.WriteLine("É Terça");
        break;
    case 3:
        Console.WriteLine("É Quinta");
        break;
    case 4:
        Console.WriteLine("É Sabadão");
        break;
}

// Sintaxe mais limpa do Switch:
int nota = 85;
string resultado = nota switch
{ 
    >= 90 => "Aprovado",
    >= 70 => "Em recuperação",
    _ => "Reprovado"
};
Console.WriteLine($"Resultado: {resultado}");

// ============== Operador Ternário ==============
Console.WriteLine("Digite a idade para ternário: ");
int idade4 = int.Parse(Console.ReadLine() ?? "0");

string resultado4 = idade4 >= 18? "Você é maior de idade": "Você é menor de idade";
Console.WriteLine(resultado4);


// ============== Validando entrada de usuário ==============
// ele usa o int.TryParse(valor_a_verificar, out int valor_de_saída)

Console.WriteLine("Digite sua idade: ");
string entrada5 = Console.ReadLine();

if (int.TryParse(entrada5, out int idade5))
{
    Console.WriteLine($"Entrada válida: {idade5}");
}
else{
    Console.WriteLine("Entrada inválida");
}