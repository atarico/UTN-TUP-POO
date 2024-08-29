using Escuela.Interfaces;

namespace Escuela.Modelos
{
    public class Escuela : EntidadConNombre, IListaEditable<Aula>
    {
        public Administrador Administrador { get; set; }

        private List<Aula> _aulas = new List<Aula>();

        public List<Aula> Aulas { get { return _aulas; } }

        public Escuela(string nombre, Administrador administrador) : base(nombre)
        {
            Administrador = administrador;
        }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Administrador.MostrarDetalles();
            Console.WriteLine("Aulas: ");
            foreach (var aula in _aulas)
            {
                aula.MostrarDetalles();
            }
        }

        public void Añadir(Aula entity)
        {
            _aulas.Add(entity);
        }

        public void Quitar(Aula entity)
        {
            _aulas.Remove(entity);
        }
    }
}
