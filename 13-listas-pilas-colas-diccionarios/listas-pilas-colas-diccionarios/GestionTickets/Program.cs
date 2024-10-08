using System;
using System.Collections.Generic;

class Ticket
{
    public int Id { get; set; }
    public string Descripcion { get; set; }

    public Ticket(int id, string descripcion)
    {
        Id = id;
        Descripcion = descripcion;
    }
}

class SistemaTickets
{
    private Queue<Ticket> cola = new Queue<Ticket>();
    private int siguienteId = 1;

    public void AgregarTicket(string descripcion)
    {
        Ticket nuevoTicket = new Ticket(siguienteId++, descripcion);
        cola.Enqueue(nuevoTicket);
        Console.WriteLine($"Ticket #{nuevoTicket.Id} agregado: {nuevoTicket.Descripcion}");
    }

    public void ProcesarTicket()
    {
        if (cola.Count == 0)
        {
            Console.WriteLine("No hay tickets para procesar.");
            return;
        }

        Ticket ticket = cola.Dequeue();
        Console.WriteLine($"Procesando Ticket #{ticket.Id}: {ticket.Descripcion}");
    }

    public void MostrarTickets()
    {
        if (cola.Count == 0)
        {
            Console.WriteLine("No hay tickets pendientes.");
            return;
        }

        Console.WriteLine("Tickets pendientes:");
        foreach (Ticket ticket in cola)
        {
            Console.WriteLine($"Ticket #{ticket.Id}: {ticket.Descripcion}");
        }
    }
}

class Program
{
    static void Main()
    {
        SistemaTickets sistema = new SistemaTickets();
        int opcion; // Inicializamos 'opcion' para entrar en el ciclo

        do
        {
            Console.WriteLine("\n=== Sistema de Gestión de Tickets de Soporte ===");
            Console.WriteLine("1. Agregar nuevo ticket");
            Console.WriteLine("2. Mostrar tickets pendientes");
            Console.WriteLine("3. Procesar siguiente ticket");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            // Intentamos convertir la opción ingresada
            //if (!int.TryParse(Console.ReadLine(), out opcion))
            //{
            //    Console.WriteLine("Opción no válida. Ingrese un número.");
            //    continue; // Si no es válido, vuelve al inicio del ciclo
            //}

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese la descripción del ticket: ");
                    string descripcion = Console.ReadLine();
                    sistema.AgregarTicket(descripcion);
                    break;
                case 2:
                    sistema.MostrarTickets();
                    break;
                case 3:
                    sistema.ProcesarTicket();
                    break;
                case 4:
                    Console.WriteLine("Gracias por usar el sistema de tickets. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                    break;
            }

        } while (opcion != 4); // El ciclo se repetirá mientras la opción no sea '4'
    }
}
