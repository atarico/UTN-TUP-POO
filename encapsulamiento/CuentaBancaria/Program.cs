class CuentaBancaria
{
    private string _titular;
    private decimal _saldo;

    public CuentaBancaria(string titular, decimal saldoInicial)
    {
        _titular = titular;
        _saldo = saldoInicial;
    }

    public string Titular
    {
        get { return _titular; }
        set { _titular = value; }
    }

    public decimal Saldo
    {
        get { return _saldo; }
        set { _saldo = value; }
    }

    public void Depositar(decimal cantidad)
    {
        if(cantidad <= 0)
        {
            Console.WriteLine("La cantidad a depositar debe ser mayor a 0");
        }
        else
        {
            //Saldo += cantidad;
            _saldo += cantidad;
            Console.WriteLine($"Depósito exitoso \n Total depositado: {cantidad} \n Saldo actual: {_saldo}");

        }
    }

    public void Retirar(decimal cantidad)
    {
        if (cantidad <= 0)
        {
            Console.WriteLine("La cantidad a retirar debe ser mayor a 0");
        }
        else if (cantidad > _saldo)
        {
            Console.WriteLine("No se puede retirar más de lo que hay en la cuenta");
        }
        else
        {
            Saldo -= cantidad;
            //_saldo -= cantidad;
        }
    }
}

class Program
{
    static void Main()
    {
        CuentaBancaria unaCuentaBancaria = new CuentaBancaria("Pepito", 1000);
        unaCuentaBancaria.Depositar(500);
        unaCuentaBancaria.Retirar(200);
        Console.WriteLine($"Titular: {unaCuentaBancaria.Titular}");
        Console.WriteLine($"Saldo: {unaCuentaBancaria.Saldo}");
    }
}