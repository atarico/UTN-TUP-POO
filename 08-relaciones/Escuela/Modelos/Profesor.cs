using Escuela.Interfaces;

namespace Escuela.Modelos
{
    public class Profesor : EntidadConNombre, IListaEditable<Materia>
    {
        private List<Materia> _materias = new List<Materia>();

        public List<Materia> Materias
        {
            get { return _materias; }
        }

        public Profesor(string nombre) : base(nombre) { }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine("Materias: ");
            foreach (var materia in _materias)
            {
                materia.MostrarDetalles();
            }
        }

        public void Añadir(Materia entity)
        {
            _materias.Add(entity);
        }

        public void Quitar(Materia entity)
        {
            _materias.Remove(entity);
        }
    }
}
