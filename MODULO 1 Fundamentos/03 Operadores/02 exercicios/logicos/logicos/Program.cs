Console.WriteLine("Olá, bem vindo ao programa");
System.Threading.Thread.Sleep(3000);
Console.Clear();

Console.WriteLine("Digite o nome: ");
string nome = Console.ReadLine() ?? "Não Informado";
Console.WriteLine("Digite a idade: ");
int idade = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("É sócio do clube? true ou false" ?? "false");
bool socio = bool.Parse(Console.ReadLine() ?? "false");
Console.WriteLine("Tem convite especial: true ou false" ?? "false");
bool conviteEspecial = bool.Parse(Console.ReadLine() ?? "false");
Console.Clear();

