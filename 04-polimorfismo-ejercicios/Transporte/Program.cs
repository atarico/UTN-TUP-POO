class Transporte
{
    public string Nombre { get; set; }

    public Transporte(string nombre)
    {
        Nombre = nombre;
    }

    public virtual void Desplazarse()
    {
        Console.WriteLine("El vehículo se desplaza");
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Vehículo: {Nombre}");
        Desplazarse();
    }
}

class Auto : Transporte
{
    public Auto(string nombre) : base(nombre) { }

    public override void Desplazarse()
    {
        Console.WriteLine("El auto se desplaza por la autopista");
    }
}

class Bicicleta : Transporte
{
    public Bicicleta(string nombre) : base(nombre) { }
    public override void Desplazarse()
    {
        Console.WriteLine($"La bici se desplaza por la bicisenda");
    }
}

class Avion : Transporte
{
    public Avion(string nombre) : base(nombre) { }
    public override void Desplazarse()
    {
        Console.WriteLine("El avión se desplaza por el aire");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el nombre del auto: ");
        Transporte unAuto = new Auto(Console.ReadLine() ?? ""); //-> Para quitar el warning de null, se puede usar el operador de coalescencia nula
        unAuto.MostrarInformacion();

        Console.Write("Ingrese el nombre de la bicicleta: ");
        Transporte unaBicicleta = new Bicicleta(Console.ReadLine());
        unaBicicleta.MostrarInformacion();

        Console.Write("Ingrese el nombre del avión: ");
        Transporte unAvion = new Avion(Console.ReadLine());
        unAvion.MostrarInformacion();
    }
}
