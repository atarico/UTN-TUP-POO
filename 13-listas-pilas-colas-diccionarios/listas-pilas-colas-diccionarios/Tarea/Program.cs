class Tarea
{
    public string Descripcion { get; private set; }
    public bool Completada { get; set; }

    public Tarea(string descripcion)
    {
        Descripcion = descripcion;
        Completada = false;
    }
}

class Program
{
    static void Main()
    {
        List<Tarea> listaTareas = new List<Tarea>();
        int opcion;

        do
        {
            Console.WriteLine("\n----- MENU DE OPCIONES -----");
            Console.WriteLine("1. Agregar nueva tarea");
            Console.WriteLine("2. Marcar tarea como completada");
            Console.WriteLine("3. Mostrar tareas pendientes");
            Console.WriteLine("4. Salir\n");
            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese la descripción de la tarea: ");
                    string descripcion = Console.ReadLine();
                    listaTareas.Add(new Tarea(descripcion));

                    break;

                case 2:
                    Console.WriteLine("Ingrese el numero de la tarea que ha completado: ");
                    int numeroTarea = int.Parse(Console.ReadLine()) - 1;
                    if (numeroTarea >= 0 && numeroTarea < listaTareas.Count)
                    {
                        listaTareas[numeroTarea].Completada = true;
                        Console.WriteLine("Tarea completada!!!");
                    }
                    else
                    {
                        Console.WriteLine("Número de tarea no válido");
                    }

                    break;

                case 3:
                    Console.WriteLine("Tareas pendientes: ");

                    //foreach (var tarea in listaTareas)
                    //{
                    //    if (!tarea.Completada)
                    //    {
                    //        Console.WriteLine(tarea.Descripcion);
                    //    }
                    //}

                    for (int i = 0; i < listaTareas.Count; i++)
                    {
                        if (!listaTareas[i].Completada)
                        {
                            Console.WriteLine($"{i + 1}. {listaTareas[i].Descripcion}");
                        }

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
