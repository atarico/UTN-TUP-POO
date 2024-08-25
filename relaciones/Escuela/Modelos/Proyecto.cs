namespace Escuela.Modelos
{
    public class Proyecto : EntidadConNombre
    {
        public string Descripcion 
        {
            get; 
            set; 
        }

        public Proyecto(string nombre, string descripcion) : base(nombre)
        {
            Descripcion = descripcion;
        }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Descripción: {Descripcion}");
        }

        public void EvaluarProyecto(Evaluador evaluador)
        {
            Console.WriteLine($"{Nombre}, está siendo evaluado por {evaluador.Nombre}");
        }
    }
}
