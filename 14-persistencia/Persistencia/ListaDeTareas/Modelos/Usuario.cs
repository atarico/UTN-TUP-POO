namespace ListaDeTareas.Modelos
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public List<Tarea> Tareas { get; set; }

        public Usuario(string nombreUsuario)
        {
            NombreUsuario = nombreUsuario;
            Tareas = new List<Tarea>();
        }

        public void AgregarTarea(Tarea tarea)
        {
            Tareas.Add(tarea);
        }

        public void MostrarTareas()
        {
            Console.WriteLine($"Tareas de {NombreUsuario}:");
            foreach (var tarea in Tareas)
            {
                Console.WriteLine(tarea);
            }
        }

        public void CambiarEstadoTarea(int indice)
        {
            if (indice >= 0 && indice < Tareas.Count)
            {
                Tareas[indice].Completada = !Tareas[indice].Completada;
            }
        }
    }
}
