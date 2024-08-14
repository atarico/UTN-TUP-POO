class PlanInternet
{
    private string _nombrePlan;
    private int _velocidad;
    private decimal _precioMensual;

    public string NombrePlan
    {
        get { return _nombrePlan; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _nombrePlan = value;
            }
            else
            {
                throw new Exception("El nombre del plan no puede estar vacío");
            }
        }
    }
    public int Velocidad
    {
        get { return _velocidad; }
        set
        {
            if (value > 0)
            {
                _velocidad = value;
            }
            else
            {
                Console.WriteLine("La velocidad debe ser mayor a 0");
            }
        }
    }
    public decimal PrecioMensual
    {
        get { return _precioMensual; }
        set
        {
            if (value > 0)
            {
                _precioMensual = value;
            }
            else
            {
                Console.WriteLine("El precio mensual debe ser mayor a 0");
            }
        }
    }

    public PlanInternet(string nombrePlan, int velocidad, decimal precioMensual)
    {
        NombrePlan = nombrePlan;
        Velocidad = velocidad;
        PrecioMensual = precioMensual;
    }

    public virtual void MostrarDetalles()
    {
        Console.WriteLine($"Nombre del plan: {NombrePlan}\nVelocidad: {Velocidad}Mbps\nPrecio mensual: ${PrecioMensual}");
    }
}

    class PlanResidencial : PlanInternet
    {
        public PlanResidencial(string nombrePlan, int velocidad, decimal precioMensual) 
            : base(nombrePlan, velocidad, precioMensual) {}

        public override void MostrarDetalles()
        {
            Console.WriteLine($"Plan residencial: Nombre: {NombrePlan}\nVelocidad: {Velocidad}Mbps\nPrecio Mensual: ${PrecioMensual}");
        }
    }

class PlanEmpresarial : PlanInternet
{
    public PlanEmpresarial(string nombrePlan, int velocidad, decimal precioMensual)
        : base(nombrePlan, velocidad, precioMensual) { }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Plan residencial: Nombre: {NombrePlan}\nVelocidad: {Velocidad}Mbps\nPrecio Mensual: ${PrecioMensual}");
    }
}

class PlanMobile : PlanInternet
{
    public PlanMobile(string nombrePlan, int velocidad, decimal precioMensual)
        : base(nombrePlan, velocidad, precioMensual) { }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Plan residencial: Nombre: {NombrePlan}\nVelocidad: {Velocidad}Mbps\nPrecio Mensual: ${PrecioMensual}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione un tipo de plan:");
        Console.WriteLine("1. Plan Residencial");
        Console.WriteLine("2. Plan Empresarial");
        Console.WriteLine("3. Plan Mobile");
        Console.Write("Ingrese el número del plan: ");
        int tipoDePlan = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el nombre del plan: ");
        string nombrePlan = Console.ReadLine();
        Console.Write("Ingrese la velocidad: ");
        int velocidad = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el precio mensual: ");
        decimal precioMensual = decimal.Parse(Console.ReadLine());


        PlanInternet unPlanDeInternet;

        switch (tipoDePlan)
        {
            case 1:
                unPlanDeInternet = new PlanResidencial(nombrePlan, velocidad, precioMensual);
                break;
            case 2:
                unPlanDeInternet = new PlanEmpresarial(nombrePlan, velocidad, precioMensual);
                break;
            case 3:
                unPlanDeInternet = new PlanMobile(nombrePlan, velocidad, precioMensual);
                break;
            default:
                Console.WriteLine("Opción inválida");
                unPlanDeInternet = new PlanResidencial(nombrePlan, velocidad, precioMensual);
                break;
        }

        unPlanDeInternet.MostrarDetalles();
    }
}

