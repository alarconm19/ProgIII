namespace Alturas;

public static class Alturas
{
    static void Main()
    {
        int[] alturas = [170, 200, 179, 180, 150, 160, 168, 170, 181, 190];

        /*
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese una estatura: ");
            alturas[i] = int.Parse(Console.ReadLine()!);
        }
        */

        double promedio = 0;
        foreach (int t in alturas)
        {
            promedio += t;
        }

        promedio /= alturas.Length;

        double varianza = 0;
        foreach (int t in alturas)
        {
            varianza += Math.Pow(t - promedio, 2);
        }

        varianza /= alturas.Length;

        double desvEst = Math.Sqrt(varianza);

        Console.WriteLine($"Media: {promedio} \nVarianza: {varianza} \nDesviación Estandar: {desvEst}");

        foreach (int t in alturas)
        {
            Console.WriteLine(t > promedio ? $"La altura {t} esta por encima de la media. " : $"La altura {t} esta por debajo de la media. ");
        }

        double limsup = promedio + desvEst;
        double liminf = promedio - desvEst;

        foreach (int t in alturas)
        {
            if (t >= liminf && t <= limsup)
            {
                Console.WriteLine($"La altura {t} esta en el rango. ");
            }
        }

        Console.ReadKey();
    }
}