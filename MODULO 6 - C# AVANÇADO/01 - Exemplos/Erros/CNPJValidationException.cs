namespace Erros;

class CNPJValidationException : Exception // aqui estar herdando de Exception
{
    public CNPJValidationException() : base("CNPJ inválido") 
    {}

    public CNPJValidationException(string message) : base(message)
    {}
}
// base(...) é uma chamada para o construtor da classe pai (Exception)