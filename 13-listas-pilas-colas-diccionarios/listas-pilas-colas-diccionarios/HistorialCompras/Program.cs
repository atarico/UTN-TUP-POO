using System;
using System.Collections.Generic;

class Cliente
{
    public string Nombre { get; set; }
    public List<string> Compras { get; set; }

    public Cliente(string nombre)
    {
        Nombre = nombre;
        Compras = new List<string>();
    }

    public void AgregarCompra(string producto)
    {
        Compras.Add(producto);
        Console.WriteLine("Compra registrada exitosamente.");
    }

    public void MostrarHistorial()
    {
        Console.WriteLine($"Historial de compras de {Nombre}:");
        foreach (var producto in Compras)
        {
            Console.WriteLine($"- {producto}");
        }
    }
}

class HistorialCompras
{
    private Dictionary<string, Cliente> historialClientes = new Dictionary<string, Cliente>();

    public void AgregarCompra()
    {
        Console.Write("Ingrese el nombre del cliente: ");
        string nombreCliente = Console.ReadLine();
        Console.Write("Ingrese el producto comprado: ");
        string producto = Console.ReadLine();

        if (!historialClientes.ContainsKey(nombreCliente))
        {
            historialClientes[nombreCliente] = new Cliente(nombreCliente);
        }

        historialClientes[nombreCliente].AgregarCompra(producto);
    }

    public void MostrarHistorial()
    {
        Console.Write("Ingrese el nombre del cliente: ");
        string nombreCliente = Console.ReadLine();

        if (historialClientes.TryGetValue(nombreCliente, out Cliente cliente))
        {
            cliente.MostrarHistorial();
        }
        else
        {
            Console.WriteLine("No se encontró historial para este cliente.");
        }
    }
}

class Program
{
    static void Main()
    {
        HistorialCompras historial = new HistorialCompras();
        string opcion;
        do
        {
            Console.WriteLine("\n1. Agregar compra");
            Console.WriteLine("2. Mostrar historial de compras");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    historial.AgregarCompra();
                    break;
                case "2":
                    historial.MostrarHistorial();
                    break;
                case "3":
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != "3");
    }
}
