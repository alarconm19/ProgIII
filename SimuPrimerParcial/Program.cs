/*Elabore un programa en C# que:

Tome N períodos de tiempo (según el ejemplo N=4; A, B, C y D).
Cada uno de estos períodos tiene un instante de tiempo (fecha-hora) en el que inicia, otro en el que finaliza y una duración.
        Luego realice la UNIÓN de los mismos
        De dos o más períodos que se solapan resultará un período nuevo (por ej. ABC, nótese que en este caso el período resultante sería la fecha-hora de inicio de A y la de finalización de B)
Si los períodos no se solapan, estos quedarán por separado (por ej. D)
Y finalmente retorne los M períodos disjuntos resultantes, es decir, que no se solapen entre sí, ordenados de forma creciente (según el ejemplo M=2).
        Consideraciones:

Podrá hacer uso de los elementos del lenguaje vistos hasta el momento.
        Los N períodos de tiempo estarán pre cargados en un arreglo.
        Además de la funcionalidad del código se valorará su correcto diseño.
        Coloque toda la solución en un archivo comprimido y súbala.
*/


namespace SimuPrimerParcial;

internal static class Parcial
{
    class TimePeriod(string nombre, DateTime ini, DateTime fin) : IComparable<TimePeriod>
    {
        public string Nombre { get; } = nombre;
        public DateTime Inicio { get; } = ini;
        TimeSpan Duracion { get; } = fin - ini;
        public DateTime Final { get; } = fin;


        public override string ToString()
        {
            return $"Nombre: {Nombre} - Inicio: {Inicio} - Duracion: {Duracion.Days} - Fin: {Final}.";
        }
        

        public int CompareTo(TimePeriod? other)
        {
            return other == null ? 1 : Inicio.CompareTo(other.Inicio);
        }
    }

    static bool SeSolapan(TimePeriod a, TimePeriod b)
    {
        return a.Final >= b.Inicio && a.Inicio <= b.Final;
    }

    static TimePeriod Union(TimePeriod a, TimePeriod b)
    {
        string nombre;

        DateTime ini;

        if (a.Inicio < b.Inicio)
        {
            nombre = a.Nombre + b.Nombre;
            ini = a.Inicio;
        }
        else
        {
            nombre = b.Nombre + a.Nombre;
            ini = b.Inicio;
        }

        var fin = a.Final > b.Final ? a.Final : b.Final;

        return new TimePeriod(nombre, ini, fin);
    }

    static void Main()
    {
        TimePeriod[] timePeriods = new TimePeriod[5];

        var a = new DateTime(2024, 3, 1);

        timePeriods[0] = new TimePeriod("a", a, a.AddDays(4));
        timePeriods[1] = new TimePeriod("b", a.AddDays(1), a.AddDays(2));
        timePeriods[2] = new TimePeriod("c", a.AddDays(5), a.AddDays(6));
        timePeriods[3] = new TimePeriod("d", a.AddDays(-4), a.AddDays(-1));
        timePeriods[4] = new TimePeriod("e", a.AddDays(6), a.AddDays(7));

        Array.Sort(timePeriods);
        foreach (var t in timePeriods)
        {
            Console.WriteLine(t.ToString());
        }


        int contAPrinc = 1;
        for (int i = 0; i <= timePeriods.Length; i++)
        {

            while ( SeSolapan(timePeriods[contAPrinc - 1], timePeriods[contAPrinc]) )
            {
                TimePeriod[] aux = timePeriods;
                timePeriods = new TimePeriod[aux.Length - 1];

                for (int j = 0, k = 0; j < aux.Length; j++)
                {
                    if (j == contAPrinc - 1)
                    {
                        timePeriods[k] = Union(aux[contAPrinc - 1], aux[contAPrinc]);
                        j++;
                    }
                    else if (j == contAPrinc) continue;
                    else timePeriods[k] = aux[j];

                    k++;
                }
                if (contAPrinc >= timePeriods.Length) break;
            }

            contAPrinc++;
            if (contAPrinc >= timePeriods.Length) break;
        }

        Console.WriteLine("\nFinal: ");
        Array.Sort(timePeriods);
        foreach (var t in timePeriods)
        {
            Console.WriteLine(t.ToString());
        }
        
    }
}