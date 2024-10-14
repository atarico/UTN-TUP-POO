namespace ListaDeTareas.Modelos
{
    public static class Sistema
    {
        static Dictionary<string, Usuario> usuarios = new Dictionary<string, Usuario>();
        static readonly string archivoDatos = "usuarios.txt";
        static readonly string separador = "|";

        public static void AgregarUsuario()
        {
            Console.WriteLine("Ingrese el nombre del usuario:");
            string nombreUsuario = Console.ReadLine();

            if (!usuarios.ContainsKey(nombreUsuario))
            {
                usuarios[nombreUsuario] = new Usuario(nombreUsuario);
                Console.WriteLine($"Usuario {nombreUsuario} agregado.");
            }
            else
            {
                Console.WriteLine("El usuario ya existe.");
            }
        }

        public static void AgregarTareaAUsuario()
        {
            Console.WriteLine("Ingrese el nombre del usuario:");
            string nombreUsuario = Console.ReadLine();

            if (usuarios.ContainsKey(nombreUsuario))
            {
                Console.WriteLine("Ingrese la descripción de la tarea:");
                string descripcion = Console.ReadLine();

                usuarios[nombreUsuario].AgregarTarea(new Tarea(descripcion));
                Console.WriteLine($"Tarea agregada al usuario {nombreUsuario}.");
            }
            else
            {
                Console.WriteLine("El usuario no existe.");
            }
        }

        public static void CambiarEstadoTareaDeUsuario()
        {
            Console.WriteLine("Ingrese el nombre del usuario:");
            string nombreUsuario = Console.ReadLine();

            if (usuarios.ContainsKey(nombreUsuario))
            {
                Console.WriteLine("Ingrese el número de la tarea a cambiar (empezando desde 0):");
                int indice = int.Parse(Console.ReadLine());

                usuarios[nombreUsuario].CambiarEstadoTarea(indice);
                Console.WriteLine("Estado de la tarea cambiado.");
            }
            else
            {
                Console.WriteLine("El usuario no existe.");
            }
        }

        public static void MostrarTareasDeUsuario()
        {
            Console.WriteLine("Ingrese el nombre del usuario:");
            string nombreUsuario = Console.ReadLine();

            if (usuarios.ContainsKey(nombreUsuario))
            {
                usuarios[nombreUsuario].MostrarTareas();
            }
            else
            {
                Console.WriteLine("El usuario no existe.");
            }
        }

        public static void GuardarDatos()
        {
            using (StreamWriter writer = new StreamWriter(archivoDatos))
            {
                foreach (var usuario in usuarios)
                {
                    writer.WriteLine(usuario.Key); // Nombre del usuario

                    foreach (var tarea in usuario.Value.Tareas)
                    {
                        writer.WriteLine($"{tarea.Descripcion}|{tarea.Completada}");
                    }
                    writer.WriteLine("-"); // Separador entre usuarios
                }
            }
            Console.WriteLine("Datos guardados correctamente.");
        }

        public static void CargarDatos()
        {
            if (File.Exists(archivoDatos))
            {
                using (StreamReader reader = new StreamReader(archivoDatos))
                {
                    string linea;
                    Usuario usuarioActual = null;

                    while ((linea = reader.ReadLine()) != null)
                    {
                        if (linea == "-")
                        {
                            usuarioActual = null; // Fin de un usuario
                        }
                        else if (usuarioActual == null)
                        {
                            usuarioActual = new Usuario(linea);
                            usuarios[linea] = usuarioActual; // Nueva entrada en el diccionario
                        }
                        else
                        {
                            string[] partes = linea.Split('|');
                            string descripcion = partes[0];
                            bool completada = bool.Parse(partes[1]);

                            usuarioActual.AgregarTarea(new Tarea(descripcion, completada));
                        }
                    }
                }
            }
            Console.WriteLine("Datos cargados correctamente.");
        }
    }
}
