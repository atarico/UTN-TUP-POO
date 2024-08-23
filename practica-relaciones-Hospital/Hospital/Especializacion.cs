using System;

namespace HospitalCentral
{

    public class Especializacion
    {
	    public string Nombre { get; set; }

        public Especializacion(string nombre)
	    {
		    Nombre = nombre;
        }

	    public string ObtenerEspecializacion()
        {
            return Nombre;
        }
    }
}

