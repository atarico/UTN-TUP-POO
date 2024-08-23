namespace HospitalCentral.Modelos
{
    public class Procedimiento
    {
        public string Nombre { get; set; }
        private List<EquipoMedico> _equiposMedicos;

        public Procedimiento(string nombre)
        {
            Nombre = nombre;
            _equiposMedicos = new List<EquipoMedico>();
        }

        public void AgregarEquipoMedico(EquipoMedico equipo)
        {
            _equiposMedicos.Add(equipo);
        }

        public void AsignarSala(SalaDeOperaciones sala)
        {
            sala.ReservarSala();
        }

    }
}
