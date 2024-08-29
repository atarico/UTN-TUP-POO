class Clima
{
    public double Temperatura { get; set; }
    public string Condicion { get; set; }


    public Clima(double temperatura, string condicion)
    {
        Temperatura = temperatura;
        Condicion = condicion;
    }

    public void MostrarDetalles()
    {
        Console.WriteLine($"Temperatura: {Temperatura}°C\n" +
            $"Condicion: {Condicion}");
    }
}


class Ubicacion
{
    public string Ciudad { get; set; }
    public string Pais { get; set; }
    public Clima Clima { get; set; }

    public Ubicacion(string ciudad, string pais, Clima clima)
    {
        Ciudad = ciudad;
        Pais = pais;
        Clima = clima;
    }

    public void MostrarDetalles()
    {
        Console.WriteLine($"Ubicacion: {Ciudad}, {Pais}");
        Clima.MostrarDetalles();
    }
}

class Meteorologo
{
    public string Nombre { get; set; }
    public string Especialidad { get; set; }

    public Meteorologo(string nombre, string especialidad)
    {
        Nombre = nombre;
        Especialidad = especialidad;
    }

    public void MostrarDetall()
    {
        Console.WriteLine($"Meteorólogo: {Nombre}");
        Console.WriteLine($"Especialidad: {Especialidad}");
    }
}

class Estacion
{
    public Ubicacion Ubicacion { get; set; }
    public Meteorologo Meteorologo { get; set; }

    public Estacion(Ubicacion ubicacion, Meteorologo meteorologo)
    {
        Ubicacion = ubicacion;
        Meteorologo = meteorologo;
    }

    public void MostrarDetalle()
    {
        Console.WriteLine("\nDetalles de la Estación:");
        Ubicacion.MostrarDetalles();
        Meteorologo.MostrarDetall();
    }
}


class RedClimatica
{
    public string Jefe { get; set; }
    private List<Estacion> _estaciones;

    public RedClimatica(string jefe, List<Estacion> estaciones)
    {
        Jefe = jefe;
        if (estaciones.Count < 2)
        {
            throw new Exception("Cantidad de estaciones no válidas. Se necesitan al menos 2");
        }
        _estaciones = estaciones;

        //foreach(var estacion in estaciones)
        //{
        //    _estaciones.Add(estacion);
        //}
    }

    public void AgregarEstacion(Estacion estacion)
    {
        _estaciones.Add(estacion);
    }

    public void MostrarDetalle()
    {
        Console.WriteLine($"Jefe De la red: {Jefe}");
        foreach (var estacion in _estaciones)
        {
            estacion.MostrarDetalle();
        }
    }
}


class Program
{
    static void Main()
    {
        Clima unClima = new Clima(11, "Nublado");

        Ubicacion unaUbicacion = new Ubicacion("San Nicho", "Argentina PAPAAAA", unClima);

        Meteorologo meteorologo1 = new Meteorologo("Pepito", "Agricola");
        Meteorologo meteorologo2 = new Meteorologo("Jorgito", "Normal");

        Estacion estacion1 = new Estacion(unaUbicacion, meteorologo1);
        Estacion estacion2 = new Estacion(unaUbicacion, meteorologo2);

        RedClimatica unaRedClimatica = new RedClimatica("Juancito", new List<Estacion> { estacion1, estacion2 });

        unaRedClimatica.MostrarDetalle();
    }
}