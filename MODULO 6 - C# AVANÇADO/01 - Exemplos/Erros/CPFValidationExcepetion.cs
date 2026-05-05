namespace Erros;

class CPFValidationException : Exception
{
    public CPFValidationException() : base("CPF invlálido")
    {
    }
    public CPFValidationException(string message) : base(message)
    {
    }
}