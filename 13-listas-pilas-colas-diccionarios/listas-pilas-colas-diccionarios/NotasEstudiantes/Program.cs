using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear un diccionario para almacenar nombres de estudiantes y sus calificaciones
        Dictionary<string, int> calificacionesEstudiantes = new Dictionary<string, int>();
        int opcion;

        do
        {
            // Mostrar el menú
            Console.WriteLine("\n---- Menú ----");
            Console.WriteLine("1. Agregar estudiante y su calificación");
            Console.WriteLine("2. Mostrar calificaciones de los estudiantes");
            Console.WriteLine("3. Modificar la calificación de un estudiante");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");

            // Leer la opción del usuario
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Agregar estudiante y su calificación
                    Console.Write("Ingresa el nombre del estudiante: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingresa la calificación: ");
                    int calificacion = int.Parse(Console.ReadLine());

                    if (calificacionesEstudiantes.ContainsKey(nombre))
                    {
                        Console.WriteLine("El estudiante ya existe. Usa la opción 3 para modificar su calificación.");
                    }
                    else
                    {
                        calificacionesEstudiantes.Add(nombre, calificacion);
                        Console.WriteLine("Estudiante agregado.");
                    }
                    break;

                case 2:
                    // Mostrar todas las calificaciones
                    if (calificacionesEstudiantes.Count > 0)
                    {
                        Console.WriteLine("\nCalificaciones de los estudiantes:");
                        foreach (var estudiante in calificacionesEstudiantes)
                        {
                            Console.WriteLine($"{estudiante.Key}: {estudiante.Value}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay estudiantes registrados.");
                    }
                    break;

                case 3:
                    // Modificar la calificación de un estudiante
                    Console.Write("Ingresa el nombre del estudiante para modificar su calificación: ");
                    string nombreModificar = Console.ReadLine();

                    if (calificacionesEstudiantes.ContainsKey(nombreModificar))
                    {
                        Console.Write("Ingresa la nueva calificación: ");
                        int nuevaCalificacion = int.Parse(Console.ReadLine());
                        calificacionesEstudiantes[nombreModificar] = nuevaCalificacion;
                        Console.WriteLine("Calificación modificada.");
                    }
                    else
                    {
                        Console.WriteLine("El estudiante no está registrado.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }
        }
        while (opcion != 4);
    }
}
