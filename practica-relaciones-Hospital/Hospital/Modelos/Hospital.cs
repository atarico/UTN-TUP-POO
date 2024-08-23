namespace HospitalCentral.Modelos
{
    public class Hospital
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        private List<Departamento> _departamentos;

        public Hospital(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
            _departamentos = new List<Departamento>();
        }

        public void AgregarDepartamento(Departamento depto)
        {
            _departamentos.Add(depto);
        }
        public void QuitarDepartamento(Departamento depto)
        {
            _departamentos.Remove(depto);
        }

        public List<Departamento> ObtenerDepartamentos()
        {
            return _departamentos;
        }
    }
}
