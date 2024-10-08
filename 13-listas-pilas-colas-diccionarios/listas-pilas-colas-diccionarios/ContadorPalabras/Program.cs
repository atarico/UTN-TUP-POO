public class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una frase: ");
        string frase = Console.ReadLine();

        Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();
        string[] palabras = frase.Split(' ');
        Console.WriteLine($"\nLa frase tiene {palabras.Length} palabras\n");

        foreach (var palabra in palabras)
        {
            if (contadorPalabras.ContainsKey(palabra))
            {
                contadorPalabras[palabra]++;
            }
            else
            {
                contadorPalabras.Add(palabra, 1);
            }
        }

        Console.WriteLine("Frecuencia de palabras: ");
        foreach (var palabra in contadorPalabras)
        {
            Console.WriteLine($"{palabra.Key}: {palabra.Value}");
        }
    }
}