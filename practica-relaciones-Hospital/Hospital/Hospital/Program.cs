using HospitalCentral.Modelos;

namespace HospitalCentral
{
    class Program
    {
        static void Main()
        {
            Especializacion especializacion = new Especializacion("Cardiología");

            Hospital hospital = new Hospital("Hospital Central", "Calle falsa 123");

            //Departamento
            
            Departamento cardiologia = new Departamento("Cardiología");

            Medico drHouse = new Medico("Dr. House", especializacion);

            //Paciente
            Paciente paciente = new Paciente("Juan Perez", 30);

            //Procedimiento
            Procedimiento procedimiento = new Procedimiento("Cirugía de corazón");

            //EquipoMedico
            EquipoMedico equipoMedico = new EquipoMedico("Equipo de cirugía", "Cirugía");

            //Sala
            SalaDeOperaciones sala = new SalaDeOperaciones(1);
            
            hospital.AgregarDepartamento(cardiologia);

            cardiologia.AgregarMedico(drHouse);

            drHouse.AtenderPaciente(paciente);

            cardiologia.AgregarProcedimiento(procedimiento);

            procedimiento.AsignarSala(sala);


        }
    }

}