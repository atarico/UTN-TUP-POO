class TarjetaIdentificacion
{
    private static int _tarjetas = 0;
    public string Nombre { get; private set; }
    public string Apellido { get; private set; }
    public int NumeroIdentificacion { get; private set; }
    public DateTime FechaEmision { get; private set; }

    public TarjetaIdentificacion(string nombre, string apellido)
    {
        Nombre = nombre;
        Apellido = apellido;
        NumeroIdentificacion = ++_tarjetas;
        FechaEmision = DateTime.Now;
    }

    public void MostrarDetalles()
    {
        Console.WriteLine($"\nTarjeta de Identificación: \n{Nombre} {Apellido}, \nID: {NumeroIdentificacion}, \nFecha de Emisión: {FechaEmision.ToShortDateString()}\n");
    }
}

class Empleado
{
    public string Nombre { get; private set; }
    public string Apellido { get; private set; }
    public TarjetaIdentificacion TarjetaIdentificacion { get; private set; }

    public Empleado(string nombre, string apellido)
    {
        Nombre = nombre;
        Apellido = apellido;
        TarjetaIdentificacion = new TarjetaIdentificacion(Nombre, Apellido);
    }

    public void MostrarDetallesEmpleado()
    {
        Console.WriteLine($"\nEmpleado: {Nombre} {Apellido}");
        TarjetaIdentificacion.MostrarDetalles();
    }
}

class Program
{
    static void Main()
    {
        //TarjetaIdentificacion unaTarjeta = new TarjetaIdentificacion("Pepito", "Jorgito", "0303456",);
        Empleado unEmpleado = new Empleado("Pepito", "Jorgito");
        Empleado unaEmpleada = new Empleado("Pepita", "Jorgita");

        unEmpleado.MostrarDetallesEmpleado();
        unaEmpleada.MostrarDetallesEmpleado();
    }
}