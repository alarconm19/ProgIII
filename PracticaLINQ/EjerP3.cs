namespace PracticaLINQ;

public class EjerP3
{
    public static void Ejer1()
    {
        List<string> palabras = ["gato", "pete", "manzana", "perro", "ojotas"];

        var gruposPorLongitud = palabras.GroupBy(palabra => palabra.Length)
                                        .OrderBy(grupo => grupo.Key)
                                        .Select(g => new { Longitud = g.Key, Palabras = g.OrderBy(p => p) });

         // Mostrar resultados
        foreach (var grupo in gruposPorLongitud)
        {
            Console.WriteLine($"Longitud: {grupo.Longitud}");
            foreach (var palabra in grupo.Palabras)
            {
                Console.WriteLine($" - {palabra}");
            }
        }
    }

    public static void Ejer4()
    {
        var productos = new List<(string Nombre, decimal Precio, string Categoria)>
        {
            ("Coca-Cola Zero", 20, "Bebidas"), ("Coca-Cola", 18, "Bebidas"), ("Shampoo Sedal", 19, "Cuidado Personal"), ("Frutillas", 64, "Frutas"), ("Arroz", 20, "Almacen"), ("Yogur", 25, "Lacteos"), ("Talco", 15, "Cuidado Personal"), ("Lavandina", 30, "Limpieza"), ("Palta", 60, "Frutas"), ("Pan", 25, "Almacen"), ("Leche", 40, "Lacteos"), ("Bananas", 20, "Frutas"), ("Jabon", 10, "Cuidado Personal"), ("Desodorante", 30, "Cuidado Personal"), ("Papas", 30, "Almacen"), ("Queso", 50, "Lacteos"), ("Detergente", 40, "Limpieza"), ("Tomate", 30, "Frutas"), ("Arvejas", 20, "Almacen"), ("Yogur", 25, "Lacteos"), ("Shampoo Sedal", 19, "Cuidado Personal"), ("Frutillas", 64, "Frutas"), ("Arroz", 20, "Almacen"), ("Yogur", 25, "Lacteos"), ("Talco", 15, "Cuidado Personal"), ("Lavandina", 30, "Limpieza"), ("Palta", 60, "Frutas"), ("Pan", 25, "Almacen"), ("Leche", 40, "Lacteos"), ("Bananas", 20, "Frutas"), ("Jabon", 10, "Cuidado Personal"), ("Desodorante", 30, "Cuidado Personal"), ("Papas", 30, "Almacen"), ("Queso", 50, "Lacteos"), ("Detergente", 40, "Limpieza"), ("Tomate", 30, "Frutas"),
        };

        var productosMasCarosXCategoria = productos.GroupBy(producto => producto.Categoria)
                                                   .Select(g => g.OrderByDescending(p => p.Precio).First());

        foreach (var (Nombre, Precio, Categoria) in productosMasCarosXCategoria)
        {
            Console.WriteLine($"Producto más caro de la categoría {Categoria}: {Nombre} - ${Precio}");
        }
    }

    public static void Ejer5()
    {
        List<string> palabras = ["gato", "perro", "manzana", "perro", "gato", "perro", "manzana", "gato", "perro", "manzana"];

        var palabrasAgrupadasXFrecuencia = palabras.GroupBy(palabra => palabra.ToLower())
                                                   .OrderBy(grupo => grupo.Key)
                                                   .Select(g => new { Palabra = g.Key , Frecuencia = g.Count() });

        foreach (var palabra in palabrasAgrupadasXFrecuencia)
        {
            Console.WriteLine($"Frecuencia de {palabra.Palabra}: {palabra.Frecuencia}");
        }
    }

    public static void Ejer6()
    {
        var personas = new List<(string Nombre, int Edad)>
        {
            ("Juan", 25), ("Ana", 15), ("Pedro", 35), ("Lucia", 20), ("Carlos", 30), ("Maria", 40), ("Jose", 50), ("Luis", 45), ("Marta", 55), ("Pablo", 60), ("Sofia", 65), ("Fernando", 70), ("Cecilia", 75), ("Ricardo", 80), ("Mariana", 85), ("Alberto", 90), ("Elena", 95)
        };

        var personasAgrupadasXDecada = personas.GroupBy(persona => persona.Edad / 10 * 10)
                                               .Select(g => g.OrderBy(p => p.Edad).First());

        foreach (var (Nombre, Edad) in personasAgrupadasXDecada)
        {
            Console.WriteLine($"Grupo de edad: {Edad / 10 * 10}s - {Nombre} ({Edad} años)");
        }
    }

    public static void Ejer7()
    {
        var transacciones = new List<(decimal Monto, DateTime Fecha)>
        {
            (100m, new DateTime(2023, 1, 1)),
            (200m, new DateTime(2023, 2, 1)),
            (50m, new DateTime(2023, 1, 15)),
            (150m, new DateTime(2023, 3, 1))
        };

        var transaccionesFiltradasXMonto = transacciones.Where(t => t.Monto > 100)
                                                        .OrderBy(t => t.Fecha)
                                                        .ThenBy(t => t.Monto);

        Console.WriteLine("Transacciones filtradas y ordenadas:");
        foreach (var (Monto, Fecha) in transaccionesFiltradasXMonto)
        {
            Console.WriteLine($"Transacción: ${Monto} - {Fecha:dd/MM/yyyy}");
        }
    }

    public static void Ejer8()
    {
        var calificaciones = new List<(double Calificacion, double Peso)>
        {
            (90, 0.3), (80, 0.2), (85, 0.5)
        };

        double mediaPonderada = calificaciones.Sum(c => c.Calificacion * c.Peso) / calificaciones.Sum(c => c.Peso);

        Console.WriteLine($"Media ponderada: {mediaPonderada}");
    }
}