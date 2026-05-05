/*
INICIO MEU EXEMPLO CURSOR
using MySqlConnector;

// =============================================================================
// ADO.NET — conexão com MySQL (MySqlConnection)
// =============================================================================
// MySqlConnection representa uma sessão com um servidor MySQL (ou MariaDB).
// É o equivalente, no ecossistema MySQL, ao SqlConnection do SQL Server: guarda
// a connection string, abre o socket (porta padrão 3306) e expõe State,
// Open(), Close() e IDisposable — mesmo padrão mental do ADO.NET.
//
// O pacote MySqlConnector implementa ADO.NET de forma moderna e performática;
// a classe fica no namespace MySqlConnector (tipo MySqlConnection).
// =============================================================================

// String de conexão: servidor, porta, banco, usuário e senha.
// Ajuste User Id e Password conforme a sua instalação (ex.: root sem senha em dev).
// Se a senha estiver vazia, deixe Password= ou omita conforme documentação.
const string connectionString =
    "Server=localhost;Port=3306;Database=desafio_csharp_ia;User Id=root;Password=;";

// --- Criação -----------------------------------------------------------------
// O construtor de MySqlConnection recebe a string de conexão (ou ConnectionString
// depois). Até chamar Open(), nenhuma comunicação real com o MySQL ocorre.

using MySqlConnection conexao = new(connectionString);

// --- Estado antes de abrir ---------------------------------------------------
// ConnectionState: Closed antes de Open().
Console.WriteLine($"Estado (antes de abrir): {conexao.State}");

// --- Abrir a conexão ---------------------------------------------------------
// Open() negocia o protocolo com o servidor MySQL. Falhas comuns: serviço parado,
// porta bloqueada, usuário/senha incorretos, banco inexistente.

conexao.Open();

Console.WriteLine($"Estado (depois de abrir): {conexao.State}");

// Com a conexão aberta, você pode usar MySqlCommand, MySqlDataReader, transações, etc.

// --- Fechar (opcional antes do fim do 'using') -------------------------------
// Close() encerra a sessão. O bloco using chama Dispose(), que também fecha
// a conexão se necessário — boa prática para não deixar conexões penduradas.

conexao.Close();

Console.WriteLine($"Estado (depois de fechar): {conexao.State}");

// Após Dispose(), não reutilize este objeto; crie outro MySqlConnection se precisar.
FIM MEU EXEMPLO CURSOR
*/


// copiei o exemplo do Danilo no MySqlConnection:

using System;
using MySql.Data.SqlClient;

namespace ConectandoComCSharpAdoNet
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// String de conexão para SQL Server.
			// Ajuste os valores conforme seu ambiente:
			// - Server: endereco do servidor MySQL (ex.: localhost)
			// - Database: banco que voce quer acessar
			// - User Id / Password: credenciais de acesso no MySQL
			string connectionString = "Server=localhost;Port=3306;Database=desafio_csharp_ia;User ID=root;Password=;"; 	

			// O bloco using garante que o objeto MySqlConnection sera descartado
 			// automaticamente ao final do escopo, mesmo em caso de erro.
			using (MySqlConnection conexao = new MySqlConnection(connectionString))
			{
				try
				{
					Console.WriteLine("Tentando abrir conexao com o banco...");

					// Open() faz a abertura fisica da conexao com o servidor MySQL.
					conexao.Open();		

					// State mostra o estado atual da conexao (Open, Closed, etc.).
					Console.WriteLine($"Conexao aberta com sucesso! Estado atual: {conexao.State}");
				}
				catch(MySqlException ex)
				{
					// MySqlException captura erros especificos de acesso ao MySQL,
					// como credencial invalida, servidor indisponivel ou banco inexistente.
					Console.WriteLine("Erro ao conectar no MySQL:");
					Console.WriteLine(ex.Message);
				}
			}
			
			// Fora do using, a conexao já foi encerrada e liberada automaticamente.
			Console.WriteLine("Processo finalizado. Pressione qualquer tecla para sair.");
			Console.ReadKey();
		}
	}
}