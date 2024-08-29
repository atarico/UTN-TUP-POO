class Producto
{
    private string _nombre;
    private decimal _precio;
    private int _cantidadEnStock;

    public Producto(string nombre, decimal precio, int cantidadEnStock)
    {
        _nombre = nombre;
        _precio = precio;
        _cantidadEnStock = cantidadEnStock;
    }

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    public decimal Precio
    {
        get { return _precio; }
        set { _precio = value; }
    }

    public int CantidadEnStock
    {
        get { return _cantidadEnStock; }
        set { _cantidadEnStock = value; }
    }

    public void AumentarStock(int cantidad)
    {
        if (cantidad <= 0)
        {
            Console.WriteLine("La cantidad a agregar debe ser mayor a 0");
        }
        else
        {
            _cantidadEnStock += cantidad;
            Console.WriteLine($"Stock agregado exitosamente \n Cantidad agregada: {cantidad} \n Stock actual: {_cantidadEnStock}");
        }
    }

    public void DisminuirStock(int cantidad)
    {
        if (cantidad <= 0)
        {
            Console.WriteLine("La cantidad a retirar debe ser mayor a 0");
        }
        else if (cantidad > _cantidadEnStock)
        {
            Console.WriteLine("No se puede retirar más de lo que hay en stock");
        }
        else
        {
            _cantidadEnStock -= cantidad;
            Console.WriteLine($"Retiro exitoso \n Cantidad retirada: {cantidad} \n Stock actual: {_cantidadEnStock}");
        }
    }
}

class Program {
    static void Main()
    {
        Producto unProducto = new Producto("Laptop", 1200, 50);
        Console.WriteLine($"Nombre: {unProducto.Nombre} \n Precio: {unProducto.Precio} \n Stock: {unProducto.CantidadEnStock}");

        unProducto.AumentarStock(10);
        //unProducto.AumentarStock(-70);

        unProducto.DisminuirStock(20);
    }
}