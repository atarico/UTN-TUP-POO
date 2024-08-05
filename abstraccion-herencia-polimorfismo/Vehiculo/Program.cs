abstract class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public abstract void Conducir();
}


class Auto : Vehiculo
{
    public Auto(string marca, string modelo) : base(marca, modelo) { }
    public override void Conducir()
    {
        Console.WriteLine($"Usted está conduciendo un auto {Marca} {Modelo}");
    }
}

class Moto : Vehiculo
{
    public Moto(string marca, string modelo) : base(marca, modelo) { }
    public override void Conducir()
    {
        Console.WriteLine($"Usted está conduciendo una moto {Marca} {Modelo}");
    }
}

class Program
{
    static void Main()
    {
        Vehiculo elAutoDePepito = new Auto("Tesla", "Model S");
        elAutoDePepito.Conducir();

        Vehiculo laMotoDePepita = new Moto("Yamaha", "Trastornado");
        laMotoDePepita.Conducir();
    }
}

