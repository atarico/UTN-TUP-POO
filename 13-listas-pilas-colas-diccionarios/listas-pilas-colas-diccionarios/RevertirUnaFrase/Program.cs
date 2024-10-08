class Program
{
    static void Main()
    {
        Stack<char> pila = new Stack<char>();

        Console.WriteLine("Ingresa una frase:");

        string frase = Console.ReadLine();

        foreach (char cadaLetra in frase)
        {
            pila.Push(cadaLetra);
        }

        Console.Write("frase invertida: ");
        while (pila.Count > 0)
        {
            Console.Write(pila.Pop());
        }
    }
}