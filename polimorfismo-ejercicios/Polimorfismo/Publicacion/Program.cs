class Publicacion
{
    public string Titulo { get; set; }
    public string Autor { get; set; }

    public Publicacion(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Publicación: {Titulo}\nAutor: {Autor}");
    }
}

class Libro : Publicacion
{
    public string Genero { get; set; }
    public int NumeroPaginas { get; set; }

    public Libro(string titulo, string autor, string genero, int numeroPaginas) : base(titulo, autor)
    {
        Genero = genero;
        NumeroPaginas = numeroPaginas;
    }

    public void MostrarInformacionLibro()
    {
        MostrarInformacion();
        Console.WriteLine($"Género: {Genero}\nNúmero de páginas: {NumeroPaginas}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el título del libro: ");
        string titulo = Console.ReadLine() ?? ""; //-> Para quitar el warning de null, se puede usar el operador de coalescencia nula
        
        Console.Write("Ingrese el autor del libro: ");
        string autor = Console.ReadLine() ?? "";

        Console.Write("Ingrese el género del libro: ");
        string genero = Console.ReadLine() ?? "";

        Console.Write("Ingrese el número de páginas del libro: ");
        int numeroPaginas = int.Parse(Console.ReadLine() ?? "");

        Libro unLibro = new Libro(titulo, autor, genero, numeroPaginas);
        Console.WriteLine("\nInformación del libro: ");
        unLibro.MostrarInformacionLibro();
    }
}