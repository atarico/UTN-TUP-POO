abstract class DispositivoElectronico
{
    public string Marca { get; set; }

    public DispositivoElectronico(string marca)
    {
        Marca = marca;
    }

    public abstract void Encender();

}

class Televisor : DispositivoElectronico
{
    public Televisor(string marca) : base(marca) { }

    public override void Encender()
    {
        Console.WriteLine($"Encendiendo el televisor {Marca}...");
    }
}

class Radio : DispositivoElectronico
{
    public Radio(string marca) : base(marca) { }

    public override void Encender()
    {
        Console.WriteLine($"Encendiendo el radio {Marca}...");
    }
}

class Program
{
    static void Main()
    {
        DispositivoElectronico unTelevisor = new Televisor("Samsung");
        DispositivoElectronico unRadio = new Radio("Sony");

        unTelevisor.Encender();
        unRadio.Encender();
    }
}
