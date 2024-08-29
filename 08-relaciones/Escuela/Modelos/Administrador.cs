namespace Escuela.Modelos
{
    public class Administrador : EntidadConNombre
    {
        private int _experiencia;

        public int Experiencia
        {
            get { return _experiencia; }
            set
            {
                if (value >= 0)
                {
                    _experiencia = value;
                }
                else
                {
                    throw new ArgumentException("La experiencia no debe ser negativa!");
                }
            }
        }

        public Administrador(string nombre, int experiencia) : base(nombre)
        {
            Experiencia = experiencia;
        }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Experiencia: {Experiencia}\n");
        }
    }
}
