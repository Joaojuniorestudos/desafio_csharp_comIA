using Erros;
using Models;
using Servicos;

var clienteServico = new ClienteServico(); // aqui eu instaciei a classe

ExecutarExemplo(
    "Erro de campo vazio",
    new Cliente { Nome = "", Cpf = "12345678901", Cnpj = "12345678000199" },
    clienteServico);

ExecutarExemplo(
    "Erro de somente Números",
    new Cliente { Nome = "Maria", Cpf = "1233454a451", Cnpj = "12345678000199" },
    clienteServico);

ExecutarExemplo(
    "Erro Cpf inválido",
    new Cliente { Nome = "João", Cpf = "12134", Cnpj = "12345678000199" },
    clienteServico);

ExecutarExemplo(
    "Erro de Cnpj invlálido",
    new Cliente  { Nome = "Ana", Cpf = "12345678910", Cnpj = "454615464" },
    clienteServico);

ExecutarExemplo(
    "Cliente Válido",
    new Cliente { Nome = "Carlos", Cpf = "10987654321", Cnpj = "12345670001234" },
    clienteServico);    

static void ExecutarExemplo(string titulo, Cliente cliente, ClienteServico clienteServico)
{
    Console.WriteLine($"\n---- {titulo} ----");

    try
    {
        clienteServico.ValidarCliente(cliente);
        Console.WriteLine("Client validado com sucesso");
    }
    catch(VazioException ex)
    {
        Console.WriteLine("VazioException " + ex.Message);
    }
     catch(SomenteNumerosException ex)
     {
        Console.WriteLine("SomenteNumerosException " + ex.Message);
     }
     catch(CPFValidationException ex)
     {
        Console.WriteLine("CPFValidationException: " + ex.Message);
     }
     catch(CNPJValidationException ex)
     {
        Console.WriteLine("CNPJValidationException: " + ex.Message);
     }
     catch(Exception ex)
     {
        Console.WriteLine("Erro genérico: " + ex.Message);
     }
     finally
     {
        Console.WriteLine("Finalizando o exemplo");
     }
}