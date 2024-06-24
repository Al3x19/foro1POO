using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Banco
{
    // Encapsulamiento y Abstracción
    public class CuentaBancaria
    {
        private string titular;  // Propiedad encapsulada
        private decimal saldo;   // Propiedad encapsulada

        public CuentaBancaria(string titular, decimal saldo = 0)
        {
            this.titular = titular;
            this.saldo = saldo;
        }

        public void Depositar(decimal cantidad)
        {
            if (cantidad > 0)
            {
                saldo += cantidad;
            }
            else
            {
                Console.WriteLine("Cantidad no válida");
            }
        }

        public void Retirar(decimal cantidad)
        {
            if (0 < cantidad && cantidad <= saldo)
            {
                saldo -= cantidad;
            }
            else
            {
                Console.WriteLine("Cantidad no válida o saldo insuficiente");
            }
        }

        public decimal ObtenerSaldo()
        {
            return saldo;
        }

        public string ObtenerTitular()
        {
            return titular;
        }
    }
}
