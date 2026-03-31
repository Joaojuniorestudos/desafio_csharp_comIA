List<Dictionary<string, object>>  alunos = new List<Dictionary<string, object>>();

while(true)
{
	Console.Clear();
	Console.WriteLine("MENU");
	Console.WriteLine("1 - Cadastrar nov aluno");
	Console.WriteLine("2 - Exibir relatório:");
	Console.WriteLine("3 - Sair");
	Console.WriteLine("Esolha uma opção: ");
	int opcao = int.Parse(Console.ReadLine() ?? "0");

	switch(opcao)
	{
		case 1:
			Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a matricula do aluno: ");
            string matricula = Console.ReadLine(); 

            Console.WriteLine("Digite as 3 notas do aluno: ");
            double[] notas = new double[3];
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Digite a nota {i + 1}: ");
                notas[i] = double.Parse(Console.ReadLine() ?? "0");
            }

            Dictionary<string, object> novoAluno = new Dictionary<string, object>();
            novoAluno.Add("Nome", nome);
            novoAluno.Add("Matricula", "matricula");
            novoAluno.Add("Notas", notas);
            
            alunos.Add(novoAluno);
            break;

        case 2: 
            Console.Clear();
            Console.WriteLine("Relatóirio de alunos");
            Console.WriteLine("-------- Versão com Foreach --------");
            foreach(var aluno in alunos)
            {
                Console.WriteLine($"Nome: {aluno["Nome"]}");
                Console.WriteLine($"Matricula: {aluno["Matricula"]}");
                var notasAluno = (double[])(aluno["Notas"]); // aqui eu uso o cast (double[]) para converter para double
                // ainda no caso acima para conversão posso usar como `var notas = aluno["Notas"] as double[];`
                Console.WriteLine($"Notas: {string.Join(", ", notasAluno)}");
                Console.WriteLine($"Média: {notasAluno.Average().ToString("0.00")}");

                if(notasAluno?.Average() >= 7) // a interrogação é porque o valor pode vir nulo
                {
                    Console.ForegroundColor = ConsoleColor.Green; // código para escrever a linha na cor verde
                    Console.WriteLine("Aluno aprovado");
                }
                else if(notasAluno?.Average() >=5 && notasAluno?.Average() < 7) 
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Aluno em recuperação");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Aluno reprovado");
                }
                Console.ResetColor(); // pra reverter as cores ao início
                Console.WriteLine("--------------------------------------");
            }           

            Console.WriteLine("Aperte alguma tecla");
            Console.ReadLine();
            break;

        case 3:
            Console.Clear();
            Console.WriteLine("Sair");
            return;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}