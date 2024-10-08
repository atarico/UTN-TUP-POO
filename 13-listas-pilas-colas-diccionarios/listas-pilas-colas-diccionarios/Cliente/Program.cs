using System.Threading;

class Cliente
{
    public string Nombre { get; set; }
    public int NumeroDeCliente { get; set; }

    public Cliente(string nombre, int numeroDeCliente)
    {
        Nombre = nombre;
        NumeroDeCliente = numeroDeCliente;
    }
}


class Program
{
    static void Main()
    {
        Queue<Cliente> colaDeClientes = new Queue<Cliente>();
        int opcion;

        do
        {
            Console.WriteLine("\n----- MENU DE OPCIONES -----");
            Console.WriteLine("1. Agregar cliente a la cola");
            Console.WriteLine("2. Atender cliente");
            Console.WriteLine("3. Mostrar clientes en la cola");
            Console.WriteLine("4. Salir\n");
            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese nombre de cliente: ");
                    string nombre = Console.ReadLine();
                    
                    Console.WriteLine("Ingrese el numero del cliente");
                    int numeroDeCliente = int.Parse(Console.ReadLine());

                    colaDeClientes.Enqueue(new Cliente(nombre, numeroDeCliente));
                    break;

                case 2:
                    if(colaDeClientes.Count > 0)
                    {
                        Cliente clienteAtendido = colaDeClientes.Dequeue();
                        Console.WriteLine($"Atendiendo al cliente: {clienteAtendido.Nombre}, Número: {clienteAtendido.NumeroDeCliente}");
                    }
                    else
                    {
                        Console.WriteLine("No hay clientes en la cola");
                    }
                    
                    break;

                case 3:
                    Console.WriteLine("Clientes en la cola: ");
                    foreach (var cliente in colaDeClientes)
                    {
                        Console.WriteLine($"Nombre: {cliente.Nombre}, Número: {cliente.NumeroDeCliente}");
                    }

                    break;

                case 4:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
        while (opcion != 4);
    }
}