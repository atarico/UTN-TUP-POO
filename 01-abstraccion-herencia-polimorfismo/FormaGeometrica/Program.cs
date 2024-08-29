abstract class FormaGeometrica
{
    public abstract double CalcularArea();
}

class Circulo : FormaGeometrica
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        Radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }
}

class Cuadrado : FormaGeometrica
{
    public double Largo { get; set; }
    public double Ancho { get; set; }

    public Cuadrado(double largo, double ancho)
    {
        Largo = largo;
        Ancho = ancho;
    }

    public override double CalcularArea()
    {
        return Largo * Ancho;
    }

    class Program
    {
        static void Main()
        {
            FormaGeometrica unCirculo = new Circulo(5);
            FormaGeometrica unCuadrado = new Cuadrado(5, 5);

            Console.WriteLine($"El área del círculo es: {unCirculo.CalcularArea()}");
            Console.WriteLine($"El área del cuadrado es: {unCuadrado.CalcularArea()}");
        }
    }
}
