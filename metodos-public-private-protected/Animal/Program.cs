class Animal
{
    //Propiedad public accesible desde cualquier lugar
    public string Nombre { get; set; }
    //Propiedad private accesible solo desde la clase
    protected int Edad { get; set; }
    //Propiedad protected accesible desde la clase y sus derivadas
    private string _tipo;

    public Animal(string nombre, int edad, string tipo)
    {
        Nombre = nombre;
        Edad = edad;
        this._tipo = tipo;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre} \n Edad: {Edad} \n Tipo: {_tipo} \n");
    }
}

class Perro : Animal
{
    public string Raza { get; set; }
    public Perro(string nombre, int edad, string tipo, string raza) : base(nombre, edad, tipo)
    {
        Raza = raza;
    }

    public void MostrarInformacionPerro()
    {
        //Acceso a las propiedades public y protected de la clase 
        Console.WriteLine($"Nombre: {Nombre} \n Edad: {Edad} \n Raza: {Raza}");

        //No se puede acceder a la propiedad _tipo ya que es private
        //Console.WriteLine($"Nombre: {Nombre} \n Edad: {Edad} \n Tipo: {_tipo} \n Raza: {Raza}");
    }
}

class Program
{
    static void Main()
    {
        Perro unPichicho = new Perro("Variable", 5, "Mamifero", "Perri Perri");
        unPichicho.MostrarInformacion(); //-> se puede acceder a las propiedades y metodos de la clase Animal
        unPichicho.MostrarInformacionPerro(); //-> solo se puede acceder a las propiedades y metodos de la clase Perro
    }
}
