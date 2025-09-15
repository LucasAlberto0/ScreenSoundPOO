// Desenvolver um método da classe Conta que exibe suas informações.

class Conta
{
    public int num;
    public string titular;
    public double saldo;
    public string senha;

    public void ExibirDadosDaConta()
    {
        Console.WriteLine($"Nome do titular: {titular}");
        Console.WriteLine($"Número Indicador: {num}");
        Console.WriteLine($"Saldo: {saldo}");
        Console.WriteLine($"Senha: {senha}");
    }
}

