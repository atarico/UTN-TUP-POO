using ListaDeTareas.Modelos;

namespace ListaDeTareas
{
    public class Program
    {
        static void Main()
        {
            Sistema.CargarDatos();

            int opcion;

            do
            {
                Console.WriteLine("1. Agregar usuario");
                Console.WriteLine("2. Agregar tarea a usuario");
                Console.WriteLine("3. Cambiar estado de tarea");
                Console.WriteLine("4. Mostrar tareas de un usuario");
                Console.WriteLine("5. Guardar y salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Sistema.AgregarUsuario();
                        break;
                    case 2:
                        Sistema.AgregarTareaAUsuario();
                        break;
                    case 3:
                        Sistema.CambiarEstadoTareaDeUsuario();
                        break;
                    case 4:
                        Sistema.MostrarTareasDeUsuario();
                        break;
                }
            } while (opcion != 5);

            Sistema.GuardarDatos();
        }
    }
}