namespace Escuela.Modelos
{
    public class Estudiante : EntidadConNombre
    {
        private int _edad;

        public int Edad
        {
            get { return _edad; }
            set
            {
                if (value >= 0)
                {
                    _edad = value;
                }
                else
                {
                    throw new ArgumentException("La edad no debe ser negativa!");
                }
            }
        }

        public Estudiante(string nombre, int edad) : base(nombre)
        {
            Edad = edad;
        }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Edad: {Edad}\n");
        }
    }

}
