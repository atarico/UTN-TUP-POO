using System;


namespace HospitalCentral.Modelos
{
	public class Paciente
	{
        public string Nombre { get; set; }
		public int Edad { get; set; }
		public int Visitas { get; set; } = 0;

		public HistorialMedico Historial { get; set; }

        public Paciente(string nombre, int edad)
		{
            Nombre = nombre;
            Edad = edad;
            Historial = new HistorialMedico();
        }

		public HistorialMedico ObtenerHistorial() => Historial;
        
    }

}