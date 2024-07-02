namespace PracticaLINQ;

class EjerP1
{
    public static void Ejer1()
    {
        int[] numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        // Consulta de numeros pares
        var numerosPares = numeros.Where(n => n % 2 == 0);

        Console.WriteLine("Numeros pares: ");
        foreach (var num in numerosPares)
        {
            Console.WriteLine(num);
        }
    }

    public static void Ejer2()
    {
        string[] palabras = ["Juan", "Pedro", "Maria", "Ana", "Luis", "Carlos"];

        // Consulta de nombres que empiezan con "A"
        var palabrasConMasDe5letras = palabras.Where(n => n.Length > 5);

        Console.WriteLine("Nombres con mas de 5 letras: ");
        foreach (var nombre in palabrasConMasDe5letras)
        {
            Console.WriteLine(nombre);
        }
    }

    public static void Ejer3()
    {
        List<string> nombres = ["Juan", "Pedro", "Maria", "Ana", "Luis", "Carlos"];

        var nombresOrdenados = nombres.OrderBy(n => n);

        Console.WriteLine("Nombres ordenados: ");
        foreach (var nombre in nombresOrdenados)
        {
            Console.WriteLine(nombre);
        }
    }

    public static void Ejer4()
    {
        List<string> nombres = ["Juan", "Pedro", "Maria", "Ana", "Luis", "Carlos"];

        Console.WriteLine(@$"Elementos en la lista: {nombres.Count}");
    }

    public static void Ejer5()
    {
        List<string> elementos = ["apple", "banana", "apple", "cherry", "banana", "date"];

        var elementosUnicos = elementos.Distinct();

        Console.WriteLine("Elementos unicos: ");
        foreach (var elemento in elementosUnicos)
        {
            Console.WriteLine(elemento);
        }
    }

    public static void Ejer6()
    {
        int[] numeros =  [10, 20, 30, 40, 50];

        var promedio = numeros.Average();

        Console.WriteLine(@$"Promedio: {promedio}");
    }

    public static void Ejer7()
    {
        List<string> palabras = ["apple", "banana", "cherry"];

        palabras = palabras.Select(palabra => palabra.ToUpper()).ToList();

        Console.WriteLine("Palabras en mayusculas: ");
        foreach (var palabra in palabras)
        {
            Console.WriteLine(palabra);
        }
    }

    public static void Ejer8()
    {
        int[] numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        var numerosMayorA5 = numeros.Where(n => n > 5);

        Console.WriteLine("Numeros mayores a 5: ");
        foreach (var num in numerosMayorA5)
        {
            Console.WriteLine(num);
        }
    }

    public static void Ejer9()
    {
        List<string> palabras = ["apple", "banana", "apricot", "cherry", "blueberry", "avocado"];

        var grupo = palabras.GroupBy(palabra => palabra[0]);

        Console.WriteLine("Palabras agrupadas por la primera letra: ");
        foreach (var g in grupo)
        {
            Console.WriteLine(g.Key);
            foreach (var palabra in g)
            {
                Console.WriteLine(palabra);
            }
        }
    }

    public static void Ejer10()
    {
        int[] numeros = [5, 8, 2, 9, 3, 7];

        var numeroMaximo = numeros.Max();

        Console.WriteLine(@$"Numero maximo: {numeroMaximo}");
    }
}
