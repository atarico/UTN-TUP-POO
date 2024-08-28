public enum MetodoEnvio
{
    Estandar,
    Expres,
    Full
}

public enum Destino
{
    Nacional,
    Internacional
}

public class CalculadorCostoEnvio
{
    public double CalcularCosto(double peso)
    {
        const double tarifaPorKilo = 0.5;
        return peso * tarifaPorKilo;
    }

    public double CalcularCosto(double largo, double ancho, double alto)
    {
        const double tarifaPorVolumen = 2.0;
        double volumen = largo * ancho * alto;
        return volumen * tarifaPorVolumen;
    }

    public double CalcularCosto(double peso, Destino destino)
    {
        double tarifaBase = 10.0;
        double tarifaPorKilo = 4.0;

        switch (destino)
        {
            case Destino.Nacional:
                return tarifaBase + (peso + tarifaBase);
            case Destino.Internacional:
                return tarifaBase * 2 + (peso * tarifaPorKilo * 1.5);
            default:
                throw new ArgumentException("Destino no reconocido.");
        }

    }


    public double CalcularCosto(double peso, double largo, double ancho, double alto, MetodoEnvio metodoEnvio)
    {
        double costoBase = CalcularCosto(peso) + CalcularCosto(largo, ancho, alto);

        switch (metodoEnvio)
        {
            case MetodoEnvio.Estandar:
                return costoBase;
            case MetodoEnvio.Expres:
                return costoBase * 1.25;
            case MetodoEnvio.Full:
                return costoBase * 1.5;
            default:
                throw new ArgumentException("Método de envío no reconocido.");
        }

    }
}

public class Program
{
   public static void Main()
    {
        CalculadorCostoEnvio calculador = new CalculadorCostoEnvio();

        Console.WriteLine("Costo solo por (5kg): $" + calculador.CalcularCosto(5));
        Console.WriteLine("Costo por tamaño (2x3x4): $" + calculador.CalcularCosto(2,3,4));
        Console.WriteLine("Costo por peso y destino (5kg, Internacional): $" + calculador.CalcularCosto(5, Destino.Internacional));
        Console.WriteLine("Costo completo (5kg, 2x3x4, expres): $" + calculador.CalcularCosto(5, 2, 3, 4, MetodoEnvio.Expres));
    }
}