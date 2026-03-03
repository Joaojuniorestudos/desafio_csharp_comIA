// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* 

1 Operadores Aritméticos

Operador | Nome | Exemplo
+ | Soma | a + b
- | Subtração | a - b
* | Multiplicação | a * b
/ | Divisão | a / b
% | Módulo (resto) | a % b

*/

int a = 10;
int b = 3; 

Console.WriteLine(a + b); // 13
Console.WriteLine(a - b); // 7
Console.WriteLine(a * b); // 30
Console.WriteLine(a / b); // 3
Console.WriteLine(a % b); // 1

/* 

2 Operadores de Atribuição
Usados para atribuir valores a variáveis.
Tabela
Operador | Nome | Exemplo
= | Atribuição | a = b
+= | Atribuição de adição | a += b
-= | Atribuição de subtração | a -= b
*= | Atribuição de multiplicação | a *= b
/= | Atribuição de divisão | a /= b
%= | Atribuição de módulo (resto) | a %= b
*/

/* 
*/

int idade = 18;

Console.WriteLine(idade > 18); // false
Console.WriteLine(idade < 18); // true
Console.WriteLine(idade == 18); // true
Console.WriteLine(idade != 18); // false
Console.WriteLine(idade >= 18); // true
Console.WriteLine(idade <= 18); // true

int numero = 10;

Console.WriteLine(numero += 5); // 15
Console.WriteLine(numero -= 3); // 12
Console.WriteLine(numero *= 2); // 24
Console.WriteLine(numero /= 4); // 6
Console.WriteLine(numero %= 4); // 2