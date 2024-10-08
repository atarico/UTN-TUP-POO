namespace ListaContactos.Models
{
    public class SystemContacto
    {

        static List<Contacto> contactos = new List<Contacto>();
        static string archivoDatos = "contactos.txt";

        public static void AgregarContacto()
        {
            Console.WriteLine("Ingrese el nombre del contacto");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el teléfono del contacto");
            string telefono = Console.ReadLine();

            Console.WriteLine("Ingrese el email del contacto");
            string email = Console.ReadLine();

            contactos.Add(new Contacto(nombre, telefono, email));
            Console.WriteLine("Contacto agregado.");

        }

        public static void MostrarContacto()
        {
            Console.WriteLine("Lista de contactos:");
            foreach (var contacto in contactos)
            {
                Console.WriteLine(contacto);
            }
        }

        public static void GuardarContactos()
        {
            using (StreamWriter writer = new StreamWriter(archivoDatos))
            {
                foreach (var contacto in contactos)
                {
                    writer.WriteLine($"{contacto.Nombre},{contacto.Telefono},{contacto.Email}");
                }
            }
            Console.WriteLine("Contacto guardado correctamente");
        }

        public static void CargarContactos()
        {
            if (File.Exists(archivoDatos))
            {
                using (StreamReader reader = new StreamReader(archivoDatos))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        string[] datos = linea.Split('|');
                        string nombre = datos[0];
                        string telefono = datos[1];
                        string email = datos[2];

                        contactos.Add(new Contacto(nombre, telefono, email));
                    }
                }
                Console.WriteLine("Contactos cargados correctamente");
            }
        }
    }
}
