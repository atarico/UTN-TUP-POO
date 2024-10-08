class Program
{
    static void Main()
    {
        Stack<string> historial = new Stack<string>();
        int opcion;

        do
        {
            Console.WriteLine("----- MENU DE OPCIONES -----");
            Console.WriteLine("1. Visitar nueva Pagina");
            Console.WriteLine("2. Retroceder página");
            Console.WriteLine("3. Mostrar historial");
            Console.WriteLine("4. Salir\n");
            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese la URL de la página: ");
                    string url = Console.ReadLine();
                    historial.Push(url);
                    Console.WriteLine($"Visitando: {url}");
                    break;
                case 2:
                    if (historial.Count > 0)
                    {
                        string paginaAnterior = historial.Pop();
                        Console.WriteLine($"Retrocediendo a: {paginaAnterior}");
                    }
                    else
                    {
                        Console.WriteLine("No hay mas páginas en el historial");
                    }
                    break;
                case 3:
                    Console.WriteLine("Historial de navegación: ");
                    foreach (var pagina in historial)
                    {
                        Console.WriteLine(pagina);
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