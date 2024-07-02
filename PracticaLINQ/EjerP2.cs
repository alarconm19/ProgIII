namespace PracticaLINQ;

public class EjerP2
{
    public static void Ejer1()
    {
        List<string> palabras = ["elephant", "lion", "tiger", "cat", "dog", "rabbit", "snake"];

        var  palbrasMasLargas = palabras.OrderByDescending(palabra => palabra.Length).Take(3);

        Console.WriteLine("Las 3 palabras mas largas: ");
        foreach (var palabra in palbrasMasLargas)
        {
            Console.WriteLine(palabra);
        }
    }

    public static void Ejer2()
    {
        int[] numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        var sumaNumerosPares = numeros.Where(n => n % 2 == 0).Sum();

        Console.WriteLine(@$"La suma de los numeros pares es: {sumaNumerosPares}");
    }

    public static void Ejer3()
    {
        var personas = new List<(string Nombre, int Edad)>
        {
            ("Marcos", 30),("Alice", 30), ("Bob", 25), ("Charlie", 30), ("David", 25), ("Eve", 35)
        };

        var grupos = personas.GroupBy(persona => persona.Edad);

        foreach (var grupo in grupos)
        {
            Console.WriteLine($"Personas con edad {grupo.Key}: ");
            foreach (var (Nombre, Edad) in grupo)
            {
                Console.WriteLine(Nombre);
            }
        }
    }

    public static void Ejer4()
    {
        var productos = new List<(string Nombre, decimal Precio)>
        {
            ("Laptop", 1500), ("Smartphone", 800), ("Tablet", 500), ("Smartwatch", 300)
        };

        productos = [.. productos.OrderByDescending(producto => producto.Precio)];

        Console.WriteLine("Productos ordenados por precio: ");
        foreach (var (Nombre, Precio) in productos)
        {
            Console.WriteLine($"{Nombre} - {Precio}");
        }
    }

    public static void Ejer5()
    {
        List<string> palabras =  ["apple", "banana", "apple", "cherry", "banana", "apple"];

        string palabraMasRepetida = palabras.GroupBy(palabra => palabra)
                                            .OrderByDescending(grupo => grupo.Count())
                                            .First()
                                            .Key;


        Console.WriteLine(@$"La palabra mas repetida es: {palabraMasRepetida}");
    }

    public static void Ejer6()
    {
        int[] numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        int tercerNumeroMasGrandre = numeros.OrderByDescending(n => n).Skip(2).First();

        Console.WriteLine(@$"El tercer numero mas grande es: {tercerNumeroMasGrandre}");
    }

    public static void Ejer7()
    {
        string cadena = "hola mundo";

        var letras = cadena.GroupBy(letra => letra).Select(grupo => new { Letra = grupo.Key, Cantidad = grupo.Count() });

        Console.WriteLine("Cantidad de veces que se repite cada letra: ");
        foreach (var letra in letras)
        {
            Console.WriteLine($"{letra.Letra} - {letra.Cantidad}");
        }
    }

    public static void Ejer8()
    {
        var productos = new List<(string Nombre, decimal Precio)>
        {
            ("Laptop", 1500), ("Smartphone", 800), ("Tablet", 500), ("Smartwatch", 300)
        };

        var productosEntre500y1000 = productos.Where(producto => producto.Precio >= 500 && producto.Precio <= 1000);

        Console.WriteLine("Productos con precio entre 500 y 1000: ");
        foreach (var (Nombre, Precio) in productosEntre500y1000)
        {
            Console.WriteLine($"{Nombre} - {Precio}");
        }
    }

    public static void Ejer9()
    {
        var personas = new List<(string Nombre, int Edad)>
        {
            ("Marcos", 30),("Alice", 30), ("Bob", 25), ("Charlie", 30), ("David", 25), ("Eve", 35)
        };

        var edadesQueNoseRepiten = personas.Select(persona => persona.Edad).Distinct();

        Console.WriteLine("Edades que no se repiten: ");
        foreach (var edad in edadesQueNoseRepiten)
        {
            Console.WriteLine(edad);
        }
    }

    public static void Ejer10()
    {
        int[] numeros = [1, 3, 3, 6, 7, 8, 9];

        // Calcular la mediana
        var numerosOrdenados = numeros.OrderBy(num => num).ToArray();
        double mediana;
        int count = numerosOrdenados.Length;
        if (count % 2 == 0)
        {
            mediana = (numerosOrdenados[count / 2 - 1] + numerosOrdenados[count / 2]) / 2.0;
        }
        else
        {
            mediana = numerosOrdenados[count / 2];
        }

        // Mostrar resultado
        Console.WriteLine($"La mediana es: {mediana}");
    }
}