
namespace HospitalCentral.Modelos
{
    public class EquipoMedico
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }

        public EquipoMedico(string nombre, string tipo)
        {
            Nombre = nombre;
            Tipo = tipo;
        }

        public void AgregarAProcedimiento(Procedimiento proc)
        {
            proc.AgregarEquipoMedico(this);
        }
    }
}
