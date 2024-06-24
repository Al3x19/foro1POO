// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Feliz Cumpleaños Messi");

namespace Banco
{
    class Program
    {
        // Polimorfismo
        static void MostrarInfoCuenta(CuentaBancaria cuenta)
        {
            Console.WriteLine($"Titular: {cuenta.ObtenerTitular()}");
            Console.WriteLine($"Saldo: {cuenta.ObtenerSaldo()}");
        }

        static void Main(string[] args)
        {
            // Crear instancias de las clases
            CuentaBancaria cuentaCorriente = new CuentaBancaria("Juan Perez", 1000);
            CuentaAhorros cuentaAhorros = new CuentaAhorros("Maria Lopez", 2000, 0.05m);

            // Usar encapsulamiento y abstracción
            cuentaCorriente.Depositar(500);
            cuentaCorriente.Retirar(200);

            // Usar herencia
            cuentaAhorros.AplicarInteres();

            // Usar polimorfismo
            MostrarInfoCuenta(cuentaCorriente);
            MostrarInfoCuenta(cuentaAhorros);
        }
    }
}
