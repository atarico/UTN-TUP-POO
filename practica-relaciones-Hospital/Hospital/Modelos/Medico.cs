

namespace HospitalCentral.Modelos
{
    public class Medico
    {
        public string Nombre { get; set; }
        public Especializacion Especialidad { get; set; }
        private List<Paciente> _pacientes;

        public Medico(string nombre, Especializacion especialidad)
        {
            Nombre = nombre;
            Especialidad = especialidad;
            _pacientes = new List<Paciente>();
        }

        public void AtenderPaciente(Paciente paciente)
        {
            _pacientes.Add(paciente);
            paciente.Visitas++;
        }

        public List<Paciente> ObtenerPacientes() => _pacientes;

        public HistorialMedico ObtenerHMPaciente(Paciente pac)
        {
            return pac.ObtenerHistorial();
        }
    }
}
