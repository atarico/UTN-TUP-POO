using System;

namespace HospitalCentral
{

    public class HistorialMedico
    {
	    public string Diagnosticos { get; set; }
        public string Tratamientos { get; set; }

        public void AgregarDiagnostico(string diagnostico)
        {
            Diagnosticos += diagnostico + "\n";
        }
        public void AgregarTratamiento(string tratamiento)
        {
            Tratamientos += tratamiento + "\n";
        }
    }
}
