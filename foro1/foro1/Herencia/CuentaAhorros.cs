using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    // Herencia
    public class CuentaAhorros : CuentaBancaria
    {
        private decimal interes;

        public CuentaAhorros(string titular, decimal saldo = 0, decimal interes = 0.01m)
            : base(titular, saldo)
        {
            this.interes = interes;
        }

        public void AplicarInteres()
        {
            Depositar(ObtenerSaldo() * interes);
        }
    }
}

