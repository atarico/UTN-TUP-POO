namespace Biblioteca.Models
{
    static public class Menu
    {
        // Método para solicitar los datos de un libro y agregarlo a la biblioteca.
        // Interactúa con el usuario a través de la consola para obtener la información del libro.
        static public void ArmarPedirLibro()
        {
            Console.Write("Ingrese el código del libro: ");
            string codigo = Console.ReadLine();

            Console.Write("Ingrese el titulo del libro: ");
            string titulo = Console.ReadLine();

            Console.Write("Ingrese el autor del libro: ");
            string autor = Console.ReadLine();

            Console.Write("Ingrese la cantidad de ejemplares del libro: ");
            int cantidadEjemplares = int.Parse(Console.ReadLine());

            // Crea una nueva instancia de Libro con los datos ingresados.
            Libro libro = new Libro(codigo, titulo, autor, cantidadEjemplares);
            // Agrega el libro a la lista de libros en SysBiblioteca.
            SysBiblioteca.AgregarLibro(libro);

            Console.WriteLine("Libro Agregado!");
        }

        // Método para solicitar los datos de un usuario y agregarlo a la biblioteca.
        // Interactúa con el usuario a través de la consola para obtener el nombre del usuario.
        static public void ArmarPedirUsuario()
        {
            Console.Write("Ingrese el nombre del usuario: ");
            string nombre = Console.ReadLine();

            // Crea una nueva instancia de Usuario con el nombre ingresado.
            Usuario usuario = new Usuario(nombre);
            // Agrega el usuario a la lista de usuarios en SysBiblioteca.
            SysBiblioteca.AgregarUsuario(usuario);

            Console.WriteLine("Usuario Agregado!");
        }

        // Método para solicitar los datos necesarios y realizar un préstamo.
        // Utiliza ArmarPedirLibroYUsuario para obtener los datos y luego realiza el préstamo.
        static public void ArmarPedirPrestamo()
        {
            try
            {
                // Obtiene el libro y el usuario para el préstamo.
                var libroYUsuario = ArmarPedirLibroYUsuario();
                // Realiza el préstamo utilizando SysBiblioteca.
                SysBiblioteca.RealizarPrestamo(libroYUsuario.Libro, libroYUsuario.Usuario);
            }
            catch (ArgumentException argumentException)
            {
                // Captura y muestra cualquier error que ocurra durante el proceso.
                Console.WriteLine(argumentException.Message);
                return;
            }
        }

        // Método para solicitar los datos necesarios y realizar una devolución.
        // Utiliza ArmarPedirLibroYUsuario para obtener los datos y luego realiza la devolución.
        static public void ArmarPedirDevolucion()
        {
            try
            {
                // Obtiene el libro y el usuario para la devolución.
                var libroYUsuario = ArmarPedirLibroYUsuario();
                // Realiza la devolución utilizando SysBiblioteca.
                SysBiblioteca.DevolverLibro(libroYUsuario.Libro, libroYUsuario.Usuario);
            }
            catch (ArgumentException argumentException)
            {
                // Captura y muestra cualquier error que ocurra durante el proceso.
                Console.WriteLine(argumentException.Message);
                return;
            }
        }

        // Método auxiliar para solicitar los datos de un libro y un usuario.
        // Se utiliza tanto para préstamos como para devoluciones.
        // Retorna: Un objeto LibroUsuario que contiene el libro y el usuario seleccionados.
        // Puede lanzar ArgumentException si el libro o el usuario no se encuentran.
        static LibroUsuario ArmarPedirLibroYUsuario()
        {
            Console.Write("Ingrese el código del libro: ");
            string codigo = Console.ReadLine();

            // Obtiene la lista de libros y busca el libro por su código.
            var libros = SysBiblioteca.ObtenerLibros();
            var libro = libros.Find(libro => libro.Codigo == codigo);

            if (libro == null)
            {
                throw new ArgumentException("Libro no encontrado!");
            }

            Console.Write("Ingrese el nombre del usuario: ");
            string nombre = Console.ReadLine();

            // Obtiene la lista de usuarios y busca el usuario por su nombre.
            var usuarios = SysBiblioteca.ObtenerUsuarios();
            var usuario = usuarios.Find(usuario => usuario.Nombre == nombre);

            if (usuario == null)
            {
                throw new ArgumentException("Usuario no encontrado!");
            }

            // Retorna un objeto que contiene el libro y el usuario encontrados.
            return new LibroUsuario { Libro = libro, Usuario = usuario };
        }
    }
}