// See https://aka.ms/new-console-template for more information


// declaração de variáveis estaticas
string nome = "João";
int idade = 42; 

// declaração de variáveis dinamicas
var idade2 = 42;
var nome2 = "João";

// conversões de tipo de dados
string resultado = Convert.ToString(idade) + " -- " + nome;
string resultado2 = idade2.ToString() + " -- " + nome2;
int resultado3 = int.Parse("2") + idade; // fortemente tipado, precisa fazer a conversão para o tipo de dados

Console.WriteLine(resultado);
Console.WriteLine(resultado2);
Console.WriteLine(resultado3);

Console.WriteLine("Digte seu nome: ");
nome = Console.ReadLine() ?? "Nome não informado";
Console.WriteLine("Seu nome é: " + nome);
// Console.WriteLine($"Seu nome é: {nome}");
/*  
Aqui em notas tem vário dados sobre os escritos:

## Conversão de tipo de dados:

- -- Novo comando `dotnet build` para verificar a sintaxe do código
Por exemplo ele iria apontar um erro no comando :
`idade += "João";` porque não permite int + string (tipagem forte)
`var resultado = Convert.ToString(idade) + " - " + nome;` Aí sim vai

## Tipos de conversão:

`Convert.ToString()` ->
`(string)idade` -> mais usada para converter objetos para outro tipo de objeto.
`int.Parse(idade)` -> somente para tipos primitivos

## Mostrando informações na tela // saída de dados

`Console.WriteLine("informação");` -> pula uma linha
`Console.Write("informação");` -> não pula linha
`Console.Write("informação" + "\\n");` -> assim pula a linha

## Entrada de dados

`nome = Console.ReadLine();` - para entrar com um dados em nome.

`Console.WriteLine("Digite seu nome: ");nome - Console.Readline();Console.WriteLine("Seu nome é: " + nome);`

## Boas práticas de nomenclatura de variáveis:

- PascallCase // para nome de classes
`string UsuarioComDadosAnonimos`

- camelCase // para nome de variávies
`string usuarioComDadosAnonomus`

- snake_case // para nome de arquivos
`string usuario_com_dados_anonimos`


// primeiro exercício aula 4
string nome = "Reinaldo";
int idade = 21;
var resultado = "Nome: " + nome + ", Idade: " + Convert.ToString(idade);
Console.WriteLine("------------------------------------");
Console.WriteLine(resultado);
Console.WriteLine("------------------------------------");

var segundoNome = "João";
var segundaIdade = 21;

Console.WriteLine("------------------------------------");
Console.WriteLine($"Nome: {segundoNome}, Idade: {segundaIdade}");
Console.WriteLine("------------------------------------");

Console.WriteLine("Digite um novo número: ");
var stringNumero = Console.ReadLine() ?? "0";

Console.WriteLine("------------------------------------");
Console.WriteLine($"O número digitado foi: {stringNumero}");
var idadeNova = idade + int.Parse(stringNumero);
Console.WriteLine($"A soma dos números é: {idadeNova}");
Console.WriteLine("------------------------------------");
*/