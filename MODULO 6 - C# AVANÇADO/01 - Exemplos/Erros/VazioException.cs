namespace Erros;

class VazioException : Exception
{
    public VazioException() : base ("Erro vazio")
    {}
    
    public VazioException(string message) : base(message)
    {
        
    }
}