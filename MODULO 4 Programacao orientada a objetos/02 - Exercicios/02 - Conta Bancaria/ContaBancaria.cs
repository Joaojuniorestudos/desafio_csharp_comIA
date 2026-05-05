using System.Globalization;

// Conta corrente simplificada para exercício.
public class ContaBancaria
{
  public string Titular { get; }

  public decimal Saldo { get; private set; }

  public ContaBancaria(string titular, decimal saldoInicial)
  {
    Titular = titular;
    Saldo = saldoInicial >= 0 ? saldoInicial : 0;
  }

  public void Depositar(decimal valor)
  {
    if (valor <= 0)
      return;
    Saldo += valor;
  }

  // Retorna false se valor inválido ou saldo insuficiente.
  public bool Sacar(decimal valor)
  {
    if (valor <= 0 || valor > Saldo)
      return false;
    Saldo -= valor;
    return true;
  }

  public string Resumo()
  {
    var cultura = CultureInfo.GetCultureInfo("pt-BR");
    return $"Titular: {Titular} | Saldo: {Saldo.ToString("C", cultura)}";
  }
}
