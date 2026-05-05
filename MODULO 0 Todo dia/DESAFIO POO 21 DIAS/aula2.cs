using System;
using Alunos;

namespace Desafio21DiasOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa danilo = new Pessoa();
            danilo.Id = 1;
            danilo.Nome = "Danilo AParecido";
            danilo.Endereco = "RUa pedro Less";

            Pessoa joao = new Pessoa();
            joao.Id = 2;
            joao.Nome = "João Carlos";
            joao.Endereco = "Rua Cumina";
            
            Pessoa joyce = new Pessoa();
            joyce.Id = 3;
            joyce.Nome = "Joyce Lourenço";
            joyce.Endereco = "Rua Do Gramacho";

            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(danilo);
            pessoas.Add(joao);
            pessoas.Add(joyce);

        }
    }
}