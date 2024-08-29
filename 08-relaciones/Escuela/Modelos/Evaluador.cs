namespace Escuela.Modelos
{
    public class Evaluador : EntidadConNombre
    {
        public string Especialidad
        {
           get; 
           set; 
        }

        public Evaluador(string nombre, string especialidad) : base(nombre)
        {
            Especialidad = especialidad;
        }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Especialidad: {Especialidad}");
        }
    }
}
