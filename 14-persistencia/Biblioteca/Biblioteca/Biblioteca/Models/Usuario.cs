namespace Biblioteca.Models
{
    public class Usuario
    {
        public string Nombre { get; private set; }

        // Se inicializa como una lista vacía en la declaración para garantizar que nunca sea null.
        // Es de solo lectura para evitar que se reemplace la lista (por eso el 'privat ser;'), pero permite modificar su contenido.
        public List<Prestamo> Prestamos { get; private set; } = new List<Prestamo>();
        public Usuario(string nombre)
        {
            Nombre = nombre;
        }

        // Método para agregar un préstamo a la lista de préstamos del usuario.
        // Este método modifica el estado interno del usaurio añadiendo un nuevo préstamo.
        // Se pasa por PARAMETRO un instancia de la clase Prestamo que se va a agregar a la lista de préstamos del usuario.
        public void AgregarPrestamo(Prestamo prestamo)
        {
            Prestamos.Add(prestamo);
        }

        // Método para quitar un préstamo de la lista de préstamos del usuario.
        // Este método modifica el estado interno del usuario eliminando un préstamo existente.
        // Se pasa por PARAMETRO un instancia de la clase Prestamo que se va a eliminar de la lista de préstamos del usuario.
        public void QuitarPrestamo(Prestamo prestamo)
        {
            Prestamos.Remove(prestamo);
        }
    }
}

