class Persona
{
    private string _nombre = null!;
    private int _edad;

    // No podemos hacer esto como en los casos anteriores
    //public Persona(string nombre, int edad)
    //{
    //    _nombre = nombre;
    //    _edad = edad;
    //}

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    public int Edad
    {
        get { return _edad; }
        set { _edad = value; }
    }
}

class Program
{
    static void Main()
    {
        //Persona unaPersona = new Persona("Pepito", 20);
        Persona unaPersona = new Persona
        {
            Nombre = "Pepito",
            Edad = 20
        };

        Console.WriteLine($"Nombre: {unaPersona.Nombre}");
        Console.WriteLine($"Edad: {unaPersona.Edad}");

        //Console.WriteLine($"Nombre: {unaPersona._nombre}");
        //Console.WriteLine($"Edad: {unaPersona._edad}");
    }

}

