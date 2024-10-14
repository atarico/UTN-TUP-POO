using Biblioteca.Models;

namespace Biblioteca
{
    class Program
    {
        static void Main()
        {
            int opcion;
            // Carga los datos de libros y usuarios al iniciar el programa
            SysBiblioteca.CargarDatos();

            do
            {
                Console.WriteLine("\n");

                Console.WriteLine("1. Agregar libro.");
                Console.WriteLine("2. Agregar usuario.");
                Console.WriteLine("3. Realizar prestamo.");
                Console.WriteLine("4. Devolver libro.");
                Console.WriteLine("5. Guardar y Salir.");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\n");
                        Menu.ArmarPedirLibro();
                        break;

                    case 2:
                        Console.WriteLine("\n");
                        Menu.ArmarPedirUsuario();
                        break;

                    case 3:
                        Console.WriteLine("\n");
                        Menu.ArmarPedirPrestamo();
                        break;

                    case 4:
                        Console.WriteLine("\n");
                        Menu.ArmarPedirDevolucion();
                        break;
                }
            } while (opcion != 5);

            // Guarda los datos de libros y usuarios antes de salir del programa
            SysBiblioteca.GuardarDatos();
        }
    }
}
