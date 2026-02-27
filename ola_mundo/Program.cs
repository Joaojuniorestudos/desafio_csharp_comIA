// See https://aka.ms/new-console-template for more information
Console.WriteLine("Essa saudação");
Console.WriteLine("Olá, Mundo!");
string nome = "João"
int idade = 42; 
double altura = 1.75;

var idade2 = 42;
var nome2 = "João";

/*Aqui em notas tem vário dados sobre os escritos:

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
*/
