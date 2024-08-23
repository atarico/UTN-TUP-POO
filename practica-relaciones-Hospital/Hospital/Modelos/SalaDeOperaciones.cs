namespace HospitalCentral.Modelos
{
    public class SalaDeOperaciones
    {
        public int Numero { get; set; }

        public SalaDeOperaciones(int numero)
        {
            Numero = numero;
        }

        public void ReservarSala()
        {
            Console.WriteLine($"Sala {Numero} reservada");
        }
    }
}
