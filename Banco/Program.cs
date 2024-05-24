namespace Banco;

internal class Administracion
{
    abstract class Cuenta(double deposito)
    {
        protected double DineroDisponible { get; set; } = deposito;

        public double GetDineroDisponible()
        {
            return DineroDisponible;
        }

        public void Deposito(double deposito)
        {
            DineroDisponible += deposito;
        }

        public abstract void Retiro(double retiro);
    }

    class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(double deposito) : base(deposito)
        {
            DineroDisponible = deposito;
        }

        public override void Retiro(double retiro)
        {
            if (retiro <= DineroDisponible * 1.5)
            {
                DineroDisponible -= retiro;
                DineroDisponible *= 0.1;
            }
            else Console.WriteLine("Denegado. Supera el maximo permitido.");
        }
    }

    class CajaAhorro : Cuenta
    {
        public CajaAhorro(double deposito) : base(deposito)
        {
            DineroDisponible = deposito;
        }

        public override void Retiro(double retiro)
        {
            if (retiro > DineroDisponible) Console.WriteLine("Denegado. Supera el maximo disponible. ");
            else DineroDisponible -= retiro;

        }
    }

    class Program
    {
        static void Main()
        {
            Cuenta[] cuentas = new Cuenta[5];

            cuentas[0] = new CajaAhorro(10000);
            cuentas[1] = new CuentaCorriente(20000);
            cuentas[2] = new CuentaCorriente(5000);
            cuentas[3] = new CajaAhorro(100000);
            cuentas[4] = new CajaAhorro(60000);

            for (int i = 0; i < 100; i++)
            {

            }
        }
    }
}