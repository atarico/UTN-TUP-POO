namespace Escuela.Modelos
{
    public class Materia : EntidadConNombre
    {
        private int _creditos;

        public int Creditos
        {
            get { return _creditos; }
            set
            {
                if (value >= 0)
                {
                    _creditos = value;
                }
                else
                {
                    throw new ArgumentException("Los creditros no deben ser negativos!");
                }
            }
        }

        public Materia(string nombre, int creditos) : base(nombre)
        {
            Creditos = creditos;
        }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Creditos: {Creditos}\n");
        }
    }
}
