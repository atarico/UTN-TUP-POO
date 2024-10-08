namespace ListaContactos.Models
{
    class Program
    {
        static void Main()
        {
            SystemContacto.CargarContactos();

            int opcion;

            do
            {
                Console.WriteLine("\n ===== Menú =====\n" +
                    "1. Agregar Contacto\n" +
                    "2. Mostrar Contacto\n" +
                    "3. Guardar y salir");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        SystemContacto.AgregarContacto();
                        break;


                    case 2:
                        SystemContacto.MostrarContacto();
                        break;
                }

            } while (opcion != 3);

            SystemContacto.GuardarContactos();
        }
    }
}

