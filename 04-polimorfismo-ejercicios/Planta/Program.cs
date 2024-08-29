class Planta
{
    public string Nombre { get; set; }
    public Planta(string nombre)
    {
        Nombre = nombre;
    }

    public virtual void Florecer()
    {
        Console.WriteLine("La planta florece");
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Planta: {Nombre}");
        Florecer();
    }
}

class Arbol : Planta
{
    public Arbol(string nombre) : base(nombre) { }

    public override void Florecer()
    {
        Console.WriteLine("El árbol florece en verano");
    }
}

class Flor : Planta
{
    public Flor(string nombre) : base(nombre) { }

    public override void Florecer()
    {
        Console.WriteLine("La flor florece en primavera");
    }
}

class Programa
{
    static void Main()
    {
        Console.Write("Ingrese el nombre del árbol: ");
        Planta unArbol = new Arbol(Console.ReadLine());
        unArbol.MostrarInformacion();

        Console.Write("Ingrese el nombre de la planta: ");
        Planta unaFlor = new Flor(Console.ReadLine());
        unaFlor.MostrarInformacion();
    }
}