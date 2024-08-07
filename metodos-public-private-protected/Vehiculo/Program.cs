class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    //Metodo protegido solo accesible desde la clase y sus derivadas
    protected void MostrarInformacion()
    {
        Console.WriteLine($"Marca: {Marca} \n Modelo: {Modelo}");
    }
}

class Auto : Vehiculo
{
    public int NumeroPuertas { get; set; }

    public Auto(string marca, string modelo, int numeroPuertas) : base(marca, modelo)
    {
        NumeroPuertas = numeroPuertas;
    }

    public void MostrarInformacionAuto()
    {
        //Acceso a las propiedades public y protected de la clase 
        Console.WriteLine($"Marca: {Marca} \n Modelo: {Modelo} \n Numero de puertas: {NumeroPuertas}");
    }

}

class Program
{
    static void Main()
    {
        Auto unAuto = new Auto("Toyota", "Corolla", 4);
        // unAuto.MostrarInformacion(); //-> No se puede acceder al metodo de la clase Vehiculo por su nivel de protección
        unAuto.MostrarInformacionAuto(); //-> solo se puede acceder a las propiedades y metodos de la clase Auto
    }
}