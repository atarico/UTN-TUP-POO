class ServicioTecnico
{
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Especialidad { get; set; }

    public int AñoFundacion { get; set; }



    public ServicioTecnico()
    {
        Nombre = string.Empty; //=> Para inicializar una cadena vacía
        Direccion = string.Empty;
        Especialidad = string.Empty;
        AñoFundacion = 0;
    }
    
    public ServicioTecnico(string nombre, string direccion, string especialidad, int añoFundacion)
    {
        Nombre = nombre;
        Direccion = direccion;
        Especialidad = especialidad;
        AñoFundacion = 0;
    }

    public void MostrarDetalles()
    {
        Console.WriteLine($"Nombre: {Nombre}\n" +
            $"dirección: {Direccion}\n" +
            $"especialidad: {Especialidad}\n" +
            $"año de fundacion: {AñoFundacion}\n");
    }

    public void MostrarDetalles(bool mostrarEspecialidad)
    {
        string mensaje = $"Nombre: {Nombre}\n" +
            $"dirección: {Direccion}\n" +
            $"año de fundacion: {AñoFundacion}\n";

        //Console.WriteLine($"Nombre: {Nombre}\n" +
        //    $"dirección: {Direccion}\n" +
        //    $"año de fundacion: {AñoFundacion}\n");
        //(mostrarEspecialidad ? $"Especialidad: {Especialidad}" : ""));

        if (mostrarEspecialidad)
        {
            mensaje += $"Especialidad: {Especialidad}";
        }
        Console.WriteLine(mensaje);
    }

    public void Reparar(DispositivoElectronico dispositivoElectronico)
    {
        Console.WriteLine($"Reparando {dispositivoElectronico.GetType().BaseType}" +
            $" {dispositivoElectronico.Nombre}");
    }
    //public void Reparar<T>(DispositivoElectronico dispositivoElectronico)
    //{
    //    Console.WriteLine($"Reparando el dipositivo {dispositivoElectronico.Nombre}");
    //}
}

class DispositivoElectronico
{
    public string Nombre { get; set; }

    public DispositivoElectronico(string nombre)
    {
        Nombre = nombre;
    }
}

class Celular : DispositivoElectronico
{

    public Celular(string nombre) : base(nombre) { }
}

class Laptop : DispositivoElectronico
{

    public Laptop(string nombre) : base(nombre) { }
}

class Program
{
    static void Main()
    {
        ServicioTecnico servicioTecnico1 
            = new ServicioTecnico("UTN", "Colon 332", "informatica", 2024);
        
        Celular nokia1100 = new Celular("Nokia 1100");

        Laptop asus = new Laptop("Asus");

        servicioTecnico1.Reparar(nokia1100);


    }
}