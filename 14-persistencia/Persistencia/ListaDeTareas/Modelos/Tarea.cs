namespace ListaDeTareas.Modelos
{
    public class Tarea
    {
        public string Descripcion { get; set; }
        public bool Completada { get; set; }

        public Tarea(string descripcion, bool completada = false)
        {
            Descripcion = descripcion;
            Completada = completada;
        }

        public override string ToString()
        {
            return $"{Descripcion} - {(Completada ? "Completada" : "Pendiente")}";
        }
    }
}
