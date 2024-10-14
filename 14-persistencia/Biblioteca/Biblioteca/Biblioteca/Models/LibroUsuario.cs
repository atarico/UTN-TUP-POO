namespace Biblioteca.Models
{
    public class LibroUsuario
    {
        // El uso de "= null!" indica que esta propiedad será inicializada después de la construcción del objeto,
        // evitando advertencias de nulabilidad del compilador.
        public Libro Libro { get; set; } = null!;
        public Usuario Usuario { get; set; } = null!;
    }
}