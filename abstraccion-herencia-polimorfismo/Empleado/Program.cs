abstract class Empleado
{
    public string Nombre { get; set; }
    public double Salario { get; set; }

    public Empleado(string nombre, double salario)
    {
        Nombre = nombre;
        Salario = salario;
    }

    public abstract double CalcularSalario();
}

class EmpleadoTiempoCompleto : Empleado
{
    public EmpleadoTiempoCompleto(string nombre, double salario) : base(nombre, salario) { }

    public override double CalcularSalario()
    {
      return Salario;
    }
}

class EmpleadoTiempoParcial : Empleado
{
    public EmpleadoTiempoParcial(string nombre, double salario) : base(nombre, salario) { }
    public override double CalcularSalario() {
      return Salario / 2;
    }
}

class Program
{
    static void Main()
    {
        Empleado unEmpleadoTiempoCompleto = new EmpleadoTiempoCompleto("Pepito", 1000);
        Empleado unEmpleadoTiempoParcial = new EmpleadoTiempoParcial("Jorgito", 1000);

        Console.WriteLine($"El salario de {unEmpleadoTiempoCompleto.Nombre} es: {unEmpleadoTiempoCompleto.CalcularSalario()}");
        Console.WriteLine($"El salario de {unEmpleadoTiempoParcial.Nombre} es: {unEmpleadoTiempoParcial.CalcularSalario()}");
    }
}