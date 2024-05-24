namespace Bet365;


//elaborar una app de consola que permita apostar el resultado de arrojar un dado
//Program --- 1 ---> lanza --- 1 ---> dado
internal static class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el valor del dado a tirar: ");
        int valor = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

        var dado = new Dado();

        Console.WriteLine("Se va a tirar el dado...");

        Console.WriteLine(valor == dado.Tirar() ? "Ha acertado!" : $"Ha perdido, el valor del dado es {dado.GetValor()}");
    }
}

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