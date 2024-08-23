namespace HospitalCentral.Modelos
{
    public class Departamento
    {
        public string Nombre { get; set; }
        private List<Medico> _medicos;
        private List<Procedimiento> _procedimientos;
        private List<EquipoMedico> _equipoMedicos;

        public Departamento(string nombre)
        {
            Nombre = nombre;
            _medicos = new List<Medico>();
            _procedimientos = new List<Procedimiento>();
            _equipoMedicos = new List<EquipoMedico>();
        }

        public void AgregarMedico(Medico medico)
        {
            _medicos.Add(medico);
        }

        public void AgregarProcedimiento(Procedimiento proc)
        {
            _procedimientos.Add(proc);
        }

        public void AgregarEquipoMedico(EquipoMedico equipo)
        {
            _equipoMedicos.Add(equipo);
        }
    }
}
