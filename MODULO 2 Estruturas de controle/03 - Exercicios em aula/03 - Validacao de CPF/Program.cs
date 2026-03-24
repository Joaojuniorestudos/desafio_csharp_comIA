Console.WriteLine("Digite o CPF: ");
string cpf = Console.ReadLine() ?? "";

// Remove pontos, traço e qualquer caractere não numérico.
cpf = System.Text.RegularExpressions.Regex.Replace(cpf, "[^0-9]", "");

if (cpf.Length != 11)
{
    Console.WriteLine("CPF inválido");
    return;
}

// Rejeita CPFs com todos os dígitos iguais (ex.: 00000000000).
if (new string(cpf[0], 11) == cpf)
{
    Console.WriteLine("CPF inválido");
    return;
}

int soma1 = 0;
for (int i = 0; i < 9; i++)
{
    soma1 += (cpf[i] - '0') * (10 - i);
}
int resto1 = soma1 % 11;
int digito1 = (resto1 < 2) ? 0 : 11 - resto1;

int soma2 = 0;
for (int i = 0; i < 9; i++)
{
    soma2 += (cpf[i] - '0') * (11 - i);
}
soma2 += digito1 * 2;
int resto2 = soma2 % 11;
int digito2 = (resto2 < 2) ? 0 : 11 - resto2;

if ((cpf[9] - '0') == digito1 && (cpf[10] - '0') == digito2)
{
    Console.WriteLine("CPF válido");
}
else
{
    Console.WriteLine("CPF inválido");
}