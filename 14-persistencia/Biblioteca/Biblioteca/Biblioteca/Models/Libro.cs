namespace Biblioteca.Models
{
    public class Libro
    {
        public string Codigo { get; private set; }
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int EjemplaresDisponibles { get; private set; }
        public Libro(string codigo, string titulo, string autor, int ejemplaresDisponibles)
        {
            Codigo = codigo;
            Titulo = titulo;
            Autor = autor;
            EjemplaresDisponibles = ejemplaresDisponibles;
        }

        // Suma de a uno el número de ejemplares disponibles del libro.
        public void AgregarEjemplar() => EjemplaresDisponibles++;

        // Resta en uno el número de ejemplares disponibles del libro.
        public void QuitarEjemplar() => EjemplaresDisponibles--;

        // Devuelve una representación en string de la clase libro.
        // Retorna: Un string con las propiedades del libro separadas por punto y coma.
        public override string ToString()
        {
            return $"{Codigo};{Titulo};{Autor};{EjemplaresDisponibles}";
        }
    }
}