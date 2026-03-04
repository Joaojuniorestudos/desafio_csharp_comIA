/*Exercício 03 – Verificando notas do aluno
Crie um programa que leia o nome de um aluno e três notas (números reais) de 0 a 10.
Use operadores aritméticos e relacionais para:
Calcular a média das três notas.

Verificar se o aluno:
foi aprovado (média = 7),
está de recuperação (média entre 5 e 6.9),
foi reprovado (média  5).
No final, o programa deve exibir:
O nome do aluno.
As três notas digitadas.
A média calculada.
Uma mensagem dizendo se o aluno está aprovado, em recuperação ou reprovado.
Tente usar os operadores:
+, /
>=, <=, <, >
==, !=
*/

Console.WriteLine("Olá, bem vindo ao programa");
Console.WriteLine("Digite o nome do aluno: ");
string nomeAluno = Console.ReadLine() ?? "Não Informado";
Console.WriteLine("Digite a primeira nota: ");
double nota1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Digite a segunda nota: ");
double nota2 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Digite a terceira nota: ");
double nota3 = double.Parse(Console.ReadLine() ?? "0");

double media = (nota1 + nota2 + nota3) / 3;
bool aprovado = media >= 7;
bool recuperacao = media >= 5 && media < 7;
bool reprovado = media < 5;

Console.WriteLine($"Nome do aluno: {nomeAluno}");
Console.WriteLine($"Nota 1: {nota1} \nNota 2: {nota2} \nNota 3: {nota3} \nMédia: {media}");

Console.WriteLine($"Aprovado: {aprovado} \n Recuperação: {recuperacao} \n Reprovado: {reprovado}");

