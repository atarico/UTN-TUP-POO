class Empleado
{
    private string _nombre = null!;
    private decimal _salario;

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    protected decimal Salario 
    {
        get { return _salario; }
        set 
        {
            if(value > 0)
            {
               _salario = value;
            }
            else 
            {
                Console.WriteLine("El salario no puede ser negativo");
            }
        }
    }

    public Empleado(string nombre, decimal salario)
    {
        Nombre = nombre;
        Salario = salario;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre} \n Salario: {Salario} \n");
    }
}

class Gerente : Empleado
{
    public string Departamento { get; set; }

    public Gerente(string nombre, decimal salario, string departamento) : base(nombre, salario)
    {
        Departamento = departamento;
    }

    public void MostrarInformacionGerente()
    {
        //Acceso a las propiedades public y protected de la clase
        Console.WriteLine($"Nombre: {Nombre} \n Salario: {Salario} \n Departamento: {Departamento} \n");
    }
}

class Program
{
    static void Main()
    {
        Empleado unEmpleado = new Empleado("Pepito", 1000);
        unEmpleado.MostrarInformacion();

        Gerente unGerente = new Gerente("Jorgito", 2000, "Ventas");
        unGerente.MostrarInformacion();
        unGerente.MostrarInformacionGerente();
    }
}