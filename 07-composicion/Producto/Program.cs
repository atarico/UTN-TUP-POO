using System.Collections.Generic;

class Producto
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public int CantidadStock { get; private set; }

    public decimal Precio { get; private set; }


    public Producto(string codigo, string nombre, int cantidadStock, decimal precio)
    {
        Codigo = codigo;
        Nombre = nombre;
        CantidadStock = cantidadStock;
        Precio = precio;
    }

    public void AgregarStock(int cantidad)
    {
        CantidadStock += cantidad;
    }
}

class OrdenCompra
{
    private List<Producto> productos;

    public OrdenCompra()
    {
        productos = new List<Producto>();
    }
    public void AgregarProducto(Producto producto)
    {
        productos.Add(producto);
    }

    public decimal CalcularTotal()
    {

        decimal total = 0;
        foreach (var producto in productos)
        {
            total += producto.Precio;
        }
        return total;
    }
    public void MostrarDetalleOrden()
    {
        Console.WriteLine("Detalle de la orden de compra");
        Console.WriteLine("-------------------------------");
        foreach (var producto in productos)
        {
            Console.WriteLine($"Codigo: {producto.Codigo}");
            Console.WriteLine($"Nombre: {producto.Nombre}");
            Console.WriteLine($"Precio: {producto.Precio:C}");
            Console.WriteLine("-------------------------------");
        }

        Console.WriteLine($"Total de la orden: {CalcularTotal()}");

    }
}

class Program
{
    static void Main()
    {
        Producto producto1 = new Producto("001", "Laptop", 10, 500);
        Producto producto2 = new Producto("002", "Mouse", 20, 20);
        Producto producto3 = new Producto("003", "Teclado", 30, 30);

        OrdenCompra orden = new OrdenCompra();
        orden.AgregarProducto(producto1);
        orden.AgregarProducto(producto2);
        orden.AgregarProducto(producto3);

        orden.MostrarDetalleOrden();
    }
}