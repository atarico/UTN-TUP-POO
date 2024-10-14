namespace Biblioteca.Models
{
    static public class SysBiblioteca
    {
        static List<Libro> Libros = new();
        static List<Usuario> Usuarios = new();

        // Constantes que representan los nombres de los archivos para guardar datos de usuarios y libros.
        static readonly string ArchivoUsuario = "Usuario.txt";
        static readonly string ArchivoLibros = "Libros.txt";

        // Método estático para obtener la lista de libros.
        // Retorna: Una referencia a la lista de libros del sistema.
        public static List<Libro> ObtenerLibros() => Libros;

        // Método estático para obtener la lista de usuarios.
        // Retorna: Una referencia a la lista de usuarios del sistema.
        public static List<Usuario> ObtenerUsuarios() => Usuarios;

        // Método estático para agregar un libro a la lista de libros.
        // Parámetro:
        //   libro: El libro que se va a agregar a la lista.
        static public void AgregarLibro(Libro libro) => Libros.Add(libro);

        // Método estático para agregar un usuario a la lista de usuarios.
        // Parámetro:
        //   usuario: El usuario que se va a agregar a la lista.
        static public void AgregarUsuario(Usuario usuario) => Usuarios.Add(usuario);

        // Método estático para realizar un préstamo de un libro a un usuario.
        // Verifica la disponibilidad del libro y actualiza los registros correspondientes.
        // Parámetros:
        //   libro: El libro que se va a prestar.
        //   usuario: El usuario que realiza el préstamo.
        static public void RealizarPrestamo(Libro libro, Usuario usuario)
        {
            if (libro.EjemplaresDisponibles >= 1)
            {
                Prestamo prestamito = new Prestamo(libro, DateTime.Now);
                usuario.AgregarPrestamo(prestamito); // Método importado de Usuario.cs
                libro.QuitarEjemplar(); // Métod importado de Libro.cs
                Console.WriteLine($"Prestamo realizado con éxito.");
            }
            else
            {
                Console.WriteLine($"La cantidad de ejemplares disponibles no es suficiente");
            }
        }

        // Método estático para devolver un libro prestado por un usuario.
        // Busca el préstamo correspondiente y actualiza los registros del sistema.
        // Parámetros:
        //   libro: El libro que se va a devolver.
        //   usuario: El usuario que devuelve el libro.
        public static void DevolverLibro(Libro libro, Usuario usuario)
        {
            Prestamo prestamo = usuario.Prestamos.Find(p => p.Libro == libro);
            if (prestamo == null)
            {
                Console.WriteLine($"El usuario {usuario.Nombre} no realizó prestamo del libro {libro.Titulo} ");
            }
            else
            {
                usuario.QuitarPrestamo(prestamo); // Método importado de Usuario.cs
                libro.AgregarEjemplar(); // Método importado de Libro.cs
                Console.WriteLine($"Libro '{libro.Titulo}' devuelto ");
            }
        }

        // Método estático para guardar los datos de libros y usuarios en archivos.
        // Utiliza los nombres de archivo definidos en las constantes de la clase.
        // Este método persiste el estado actual del sistema en archivos de texto.
        public static void GuardarDatos()
        {
            // Guarda los datos de los libros en el archivo especificado por ArchivoLibros
            using StreamWriter writerLibro = new StreamWriter(ArchivoLibros);
            foreach (var libro in Libros)
            {
                // Utiliza el método ToString() de la clase Libro para escribir cada libro
                // Se asume que ToString() devuelve una representación en formato Valores Separados por Comas del libro
                writerLibro.WriteLine(libro);
            }

            // Guarda los datos de los usuarios y sus préstamos en el archivo especificado por ArchivoUsuario
            using StreamWriter writerUsuario = new StreamWriter(ArchivoUsuario);
            foreach (var usuario in Usuarios)
            {
                // Escribe el nombre del usuario
                writerUsuario.WriteLine(usuario.Nombre);
                foreach (var prestamo in usuario.Prestamos)
                {
                    // Utiliza el método ToString() de la clase Prestamo para escribir cada préstamo
                    // Se asume que ToString() devuelve una representación en formato Valores Separados por Comas del préstamo
                    writerUsuario.WriteLine(prestamo);
                }
                // Escribe un separador '+' para indicar el fin de los préstamos de un usuario
                writerUsuario.WriteLine("+");
            }
            // Nota: Los StreamWriter se cierran automáticamente al salir del bloque 'using'

            Console.WriteLine("Datos guardados exitosamente");
        }

        // Método estático para cargar los datos de libros y usuarios desde archivos.
        // Lee los archivos definidos en las constantes de la clase y reconstruye los objetos del sistema.
        // Este método restaura el estado del sistema a partir de los archivos guardados.
        public static void CargarDatos()
        {
            // Carga los datos de los libros si el archivo existe
            if (File.Exists(ArchivoLibros))
            {
                foreach (var line in File.ReadAllLines(ArchivoLibros))
                {
                    // Divide la línea en sus componentes utilizando el separador ';'
                    var datoDelArchivo = line.Split(";");
                    // Crea un nuevo objeto Libro con los datos leídos
                    // Se asume que el formato es: Código;Título;Autor;EjemplaresDisponibles
                    var libro = new Libro(datoDelArchivo[0], datoDelArchivo[1], datoDelArchivo[2], int.Parse(datoDelArchivo[3]));
                    Libros.Add(libro);
                }
            }

            // Carga los datos de los usuarios y sus préstamos si el archivo existe
            if (File.Exists(ArchivoUsuario))
            {
                using StreamReader reader = new StreamReader(ArchivoUsuario);
                string linea;
                Usuario usuario = null;
                while ((linea = reader.ReadLine()) != null)
                {
                    if (linea == "+")
                    {
                        // El separador '+' indica el fin de los préstamos de un usuario
                        usuario = null;
                    }
                    else if (usuario == null)
                    {
                        // Si no hay un usuario actual, crea uno nuevo con el nombre leído
                        usuario = new Usuario(linea);
                        Usuarios.Add(usuario);
                    }
                    else
                    {
                        // Si hay un usuario actual, procesa la línea como un préstamo
                        var datosPrestamo = linea.Split(";");
                        // Busca el libro correspondiente al código leído
                        var libro = Libros.Find(libro => libro.Codigo == datosPrestamo[0]);
                        if (libro != null)
                        {
                            // Crea un nuevo objeto Prestamo y lo añade a los préstamos del usuario
                            var prestamo = new Prestamo(libro, DateTime.Parse(datosPrestamo[1]));
                            usuario.Prestamos.Add(prestamo);
                        }
                    }
                }
                // El StreamReader se cierra automáticamente al salir del bloque 'using'
            }
        }
    }
}