class InstrumentoMusical
{
    public string Nombre { get; set; }
    public string Tipo { get; set; }

    public InstrumentoMusical(string nombre, string tipo)
    {
        Nombre = nombre;
        Tipo = tipo;
    }

    public void MostrarInformacion()
    {
       Console.WriteLine($"\nNombre: {Nombre}\nTipo: {Tipo}");
    }
}

class InstrumentoMusicalDeCuerdas : InstrumentoMusical
{

   public int CantidadCuerdas { get; set; }

    public InstrumentoMusicalDeCuerdas(string nombre, string tipo, int cantidadCuerdas) : base(nombre, tipo)
    {
        CantidadCuerdas = cantidadCuerdas;
    }

    public void MostrarInformacionCuerdas()
    {
        MostrarInformacion();
        Console.WriteLine($"Cantidad de cuerdas: {CantidadCuerdas}");
    }
}

class InstrumentoMusicalDeViento : InstrumentoMusical
{
    public string Material { get; set; }

    public InstrumentoMusicalDeViento(string nombre, string tipo, string material) : base(nombre, tipo)
    {
        Material = material;
    }

    public void MostrarInformacionViento()
    {
        MostrarInformacion();
        Console.WriteLine($"Material: {Material}");
    }
}

class Guitarra : InstrumentoMusicalDeCuerdas
{
    public Guitarra(string nombre, string tipo, int cantidadCuerdas) : base(nombre, tipo, cantidadCuerdas){ }

    public void MostrarInformacionGuitarra()
    {
        MostrarInformacionCuerdas();
    }
}

class Piano : InstrumentoMusicalDeCuerdas
{
    public int NumeroDeTeclas { get; set; }
    public Piano(string nombre, string tipo, int cantidadCuerdas, int numeroDeTeclas) : base(nombre, tipo, cantidadCuerdas)
    {
        NumeroDeTeclas = numeroDeTeclas;
    }

    public void MostrarInformacionPiano()
    {
        MostrarInformacionCuerdas();
        Console.WriteLine($"Numero de teclas: {NumeroDeTeclas}");
    }
}

class Trompeta : InstrumentoMusicalDeViento
{
    public Trompeta(string nombre, string tipo, string material) : base(nombre, tipo, material){ }

    public void MostrarInformacionTrompeta()
    {
        MostrarInformacionViento();
    }
}

class Program
{
    static void Main()
    {
        Guitarra unaGuitarra = new Guitarra("Guitarra Fender", "Cuerdas", 6);
        Piano unPiano = new Piano("Piano Yamaha", "Cuerdas", 230, 88);
        Trompeta unaTrompeta = new Trompeta("Trompeta Yamaha", "Viento", "Metal");

        unaGuitarra.MostrarInformacionGuitarra();
        unPiano.MostrarInformacionPiano();
        unaTrompeta.MostrarInformacionTrompeta();
    }
}


