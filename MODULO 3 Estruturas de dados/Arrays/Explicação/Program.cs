int[] numeros = new int[5];
numeros[0] = 1;
numeros[1] = 2;
numeros[2] = 3;
numeros[3] = 4;
numeros[4] = 5;

Console.WriteLine(numeros[0]);
Console.WriteLine(numeros[1]);
Console.WriteLine(numeros[2]);
Console.WriteLine(numeros[3]);
Console.WriteLine(numeros[4]);

// parte 2
int[,] matriz = 
{
	{10, 20, 30},
	{2, 4, 6}
};

Console.WriteLine(matriz[0,1]); // retorna o 20
Console.WriteLine(matriz[1, 0]); // retornar o 2

// parte 3
string[, ] alunos = new string[3, 2];
alunos[0, 0] = "João";
alunos[0, 1] = "8";

alunos[1, 0] = "Maria";
alunos[1, 1] = "9";

alunos[2, 0] = "Pedro";
alunos[2, 1] = "7";

Console.WriteLine($"Nome: {alunos[0, 0]}, Nota: {alunos[0, 1]}");
Console.WriteLine($"Nome: {alunos[1, 0]}, Nota: {alunos[1, 1]}");
Console.WriteLine($"Nome: {alunos[2, 0]}, Nota: {alunos[2, 1]}");