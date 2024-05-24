namespace CodificacionCesar;

internal static class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el texto cifrado:");
        string textoCifrado = Console.ReadLine()!.ToLower(); // Convertimos el texto a minúsculas para simplificar el cifrado

        Console.WriteLine("Ingrese la clave de cifrado (número entero positivo):");
        int clave;
        while (!int.TryParse(Console.ReadLine(), out clave) || clave <= 0)
        {
            Console.WriteLine("Por favor, ingrese un número entero positivo para la clave de cifrado:");
        }

        string textoDescifrado = DescifrarCesar(textoCifrado, clave);
        Console.WriteLine("Texto descifrado:");
        Console.WriteLine(textoDescifrado);
    }

    static string DescifrarCesar(string textoCifrado, int clave)
    {
        string resultado = "";
        foreach (char letra in textoCifrado)
        {
            if (char.IsLetter(letra))
            {
                char letraDescifrada = DescifrarCaracter(letra, clave);
                resultado += letraDescifrada;
            }
            else
            {
                resultado += letra;
            }
        }
        return resultado;
    }

    static char DescifrarCaracter(char letraCifrada, int clave)
    {
        char[] alfabeto = "aábcdeéfghiíjklmnñoópqrstuúüvwxyz".ToCharArray();
        int indice = Array.IndexOf(alfabeto, letraCifrada);
        int indiceDescifrado = (indice - clave + alfabeto.Length) % alfabeto.Length; // Calculamos el índice descifrado considerando que podría ser negativo
        return alfabeto[indiceDescifrado];
    }
}



