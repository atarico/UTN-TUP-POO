namespace Biblioteca.Models
{
    public class Prestamo
    {
        public Libro Libro { get; private set; }
        public DateTime FechaPrestamo { get; private set; }
        public DateTime FechaDevolucion { get; private set; }
        public Prestamo(Libro libro, DateTime fechaPrestamo)
        {
            Libro = libro;
            FechaPrestamo = fechaPrestamo;
            // La fecha de devolución se establece 10 días después de la fecha de préstamo.
            FechaDevolucion = fechaPrestamo.AddDays(10);
        }

        // Método sobrescrito para representar el objeto Prestamo como un string.
        // Retorna: Un string con el código del libro, las fechas de préstamo y devolución, separados por punto y coma.
        public override string ToString()
        {
            return $"{Libro.Codigo};{FechaPrestamo.ToShortDateString()};{FechaDevolucion.ToShortDateString()}";
        }
    }
}