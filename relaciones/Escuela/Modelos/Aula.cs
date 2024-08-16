using Escuela.Interfaces;

namespace Escuela.Modelos
{
    public class Aula : EntidadConNombre, IListaEditable<Estudiante>
    {
        public Profesor Profesor { get; set; }

        private List<Estudiante> _estudiantes = new List<Estudiante>();

        public List<Estudiante> Estudiantes { get { return _estudiantes; } }

        public Aula(string nombre, Profesor profesor) : base(nombre)
        {
            Profesor = profesor;
        }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Profesor.MostrarDetalles();
            Console.WriteLine("Estudiantes: ");
            foreach (var estudiante in _estudiantes)
            {
                estudiante.MostrarDetalles();
            }
        }

        public void Añadir(Estudiante entity)
        {
            _estudiantes.Add(entity);
        }

        public void Quitar(Estudiante entity)
        {
            _estudiantes.Remove(entity);
        }
    }
}
