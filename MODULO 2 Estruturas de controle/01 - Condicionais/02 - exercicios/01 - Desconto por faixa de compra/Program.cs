
int i = 1;
string alunos = string.Empty;

while(i <= 3){
    Console.WriteLine("Nome Aluno: ");
    alunos += Console.ReadLine() + "\n";
    i++;
}

Console.WriteLine(alunos);
