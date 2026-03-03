
/*
=============== Exercício 02 ===============
Faça um programa que solicite o nome e a idade de um candidato
depois pergnte se ele tem carteira de motorista.

no final do programa vc deve responder se:
- ele tem carteira de motorista
- se ele é maior de idade
- se ele tem carteira de motorista e é maior de idade
- se tem carteira de motorista ou é maior de idade 
- solicite mais alguns anos de idade para somar com a idade atual
- verifique se a idade do candidato está entre 18 a 35 anos
*/

Console.Clear();
Console.WriteLine("Olá candidato, bem vindo ao programa");
System.Threading.Thread.Sleep(3000);
Console.Clear();

Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine() ?? "Não informado";
Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Digite se você tem carteira de motorista: true ou false");
bool temCarteira = bool.Parse(Console.ReadLine());
Console.Clear();

Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"Tem carteira de motorista: {temCarteira}");

Console.WriteLine($"Ele tem carteira de motorista: {temCarteira}");
Console.WriteLine($"Ele é maior de idade: {idade >= 18}");
Console.WriteLine($"Ele tem carteira de motorista e é maior de idade: {temCarteira && idade >= 18}");
Console.WriteLine($"Ele tem carteira de motorista ou é maior de idade: {temCarteira || idade >= 18}");
Console.WriteLine("Digite mais alguns anos de idade para somar com a idade atual: ");
int maisAnos = int.Parse(Console.ReadLine() ?? "0");
idade += maisAnos;
Console.WriteLine($"A idade do candidato é: {idade}");
Console.WriteLine($"A idade do candidato está entre 18 a 35 anos: {idade >= 18 && idade <= 35}");