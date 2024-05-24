namespace Bet365v2;

internal class Dado
{
    const int CantLados = 6;
    int Valor { get; set; }

    public int Tirar()
    {
        var random = new Random();
        Valor = random.Next(1, CantLados + 1);
        return Valor;
    }

    public int GetValor()
    {
        return Valor;
    }
}

public enum TipoApuesta
{
    Conservador,
    Arriesgado,
    Desesperado
}

internal class Jugador
{
    public double DineroDisponible { get; private set; } = 100;
    public double ValorApuesta { get; set; }
    public TipoApuesta TipoApuesta { get; set; }
    public int ValorDado { get; set; }

    public void PerderApuesta(double perdida)
    {
        DineroDisponible -= perdida;
    }

    public void GanarApuesta(double ganancia)
    {
        DineroDisponible += ganancia;
    }

    public double PuedeApostar(TipoApuesta modo)
    {
        return DineroDisponible - ValorApuesta * Juego.Numerador(modo);
    }

    public double PuedeGanar(TipoApuesta modo)
    {
        return ValorApuesta * Juego.Denominador(modo);
    }
}

internal static class Juego
{
    public static void Main()
    {
        double pozo = 100000;

        var j1 = new Jugador();
        var j2 = new Jugador();

        do
        {
            do
            {
                Console.Write($"Jugador 1 saldo disponible: {j1.DineroDisponible}. Ingrese su modo de apuesta: \n1. Conservador \n2. Arriesgado \n3. Desesperado \nSeleccione: ");
                int modo = int.Parse(Console.ReadLine()!);

                j1.TipoApuesta = modo switch
                {
                        1 => TipoApuesta.Conservador,
                        2 => TipoApuesta.Arriesgado,
                        3 => TipoApuesta.Desesperado,
                        _ => j1.TipoApuesta
                };

                Console.Write("\nJugador 1. Ingrese su apuesta: ");
                j1.ValorApuesta = double.Parse(Console.ReadLine()!);

                Console.Write("\nJugador 1. Ingrese el valor del dado a tirar: ");
                j1.ValorDado = int.Parse(Console.ReadLine()!);


            } while (!(j1.PuedeApostar(j1.TipoApuesta) >= 0));

            //----------------------------------------------------------Jugador 1

            do
            {
                Console.Write($"\nJugador 2 saldo disponible: {j2.DineroDisponible}. Ingrese su modo de apuesta: \n1. Conservador \n2. Arriesgado \n3. Desesperado \nSeleccione: ");
                int modo = int.Parse(Console.ReadLine()!);

                j2.TipoApuesta = modo switch
                {
                        1 => TipoApuesta.Conservador,
                        2 => TipoApuesta.Arriesgado,
                        3 => TipoApuesta.Desesperado,
                        _ => j2.TipoApuesta
                };

                Console.Write("\nJugador 2. Ingrese su apuesta: ");
                j2.ValorApuesta = double.Parse(Console.ReadLine()!);

                Console.Write("\nJugador 2. Ingrese el valor del dado a tirar: ");
                j2.ValorDado = int.Parse(Console.ReadLine()!);

            } while (!(j2.PuedeApostar(j2.TipoApuesta) >= 0));

            //---------------------------------------------------Jugador 2

            pozo += j1.ValorApuesta + j2.ValorApuesta;

            var dado1 = new Dado();
            var dado2 = new Dado();

            Console.WriteLine($"\nSe van a tirar los dados...\nEl valor de los dados es {dado1.Tirar() + dado2.Tirar()}\n");

            Console.Write(j1.ValorDado == dado1.GetValor() + dado2.GetValor()
                    ? "Jugador 1 has acertado! "
                    : "Jugador 1 has perdido. ");

            if (j1.ValorDado == dado1.GetValor() + dado2.GetValor())
            {
                j1.GanarApuesta(j1.ValorApuesta * Denominador(j1.TipoApuesta));
                pozo -= j1.ValorApuesta * Denominador(j1.TipoApuesta);
            }
            else j1.PerderApuesta(j1.ValorApuesta * Numerador(j1.TipoApuesta));

            Console.WriteLine($"Su nuevo saldo es: {j1.DineroDisponible}\n");


            Console.Write(j2.ValorDado == dado1.GetValor() + dado2.GetValor()
                    ? "Jugador 2 has acertado! "
                    : "Jugador 2 has perdido. ");

            if (j2.ValorDado == dado1.GetValor() + dado2.GetValor())
            {
                j2.GanarApuesta(j2.ValorApuesta * Denominador(j2.TipoApuesta));
                pozo -= j2.ValorApuesta * Denominador(j2.TipoApuesta);
            }
            else j2.PerderApuesta(j2.ValorApuesta * Numerador(j2.TipoApuesta));

            Console.WriteLine($"Su nuevo saldo es: {j2.DineroDisponible}\n");

        } while (pozo > 0 && j1.DineroDisponible > 0 && j2.DineroDisponible > 0 );
    }

    public static int Numerador(TipoApuesta tipo)
    {
        int mult = tipo switch
        {
                TipoApuesta.Arriesgado => 2,
                TipoApuesta.Desesperado => 4,
                _ => 1
        };

        return mult;
    }

    public static int Denominador(TipoApuesta tipo)
    {
        int mult = tipo switch
        {
                TipoApuesta.Arriesgado => 5,
                TipoApuesta.Desesperado => 15,
                _ => 2
        };

        return mult;
    }
}