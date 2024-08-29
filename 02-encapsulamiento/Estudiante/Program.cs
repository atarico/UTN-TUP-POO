class Estudiante
{
    private string _nombre = null!;
    private int _legajo;
    private double _promedio;

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    public int Legajo
    {
        get { return _legajo; }
        set { _legajo = value; }
    }

    public double Promedio
    {
        get { return _promedio; }
        set
        {
            if(value >= 0 && value <= 10)
            {
                _promedio = value;
            }
            else
            {
                Console.WriteLine("El promedio debe ser mayor a 0 y menor a 10");
            }
        }
    }

    public Estudiante(string nombre, int legajo, double promedio)
    {
        _nombre = nombre;
        _legajo = legajo;
        Promedio = promedio;
    }

    public void ActualizarPromedio(double nuevoPromedio)
    {
        Promedio = nuevoPromedio;
    }
}

class Program
{
    static void Main()
    {
        Estudiante unEstudiante = new Estudiante("Pepito", 1234, 8.5);
        Console.WriteLine($"Nombre: {unEstudiante.Nombre} \n Legajo: {unEstudiante.Legajo} \n Promedio: {unEstudiante.Promedio}");
        unEstudiante.ActualizarPromedio(9.5);
        Console.WriteLine($"Nombre: {unEstudiante.Nombre} \n Legajo: {unEstudiante.Legajo} \n Promedio Actualizado: {unEstudiante.Promedio}");
    }
}