using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ContaBancaria
{
    internal class Conta
    {
        private int NumeroConta { get; set; }
        private string _nome;
        public double ValorInicial { get; set; }
        public double Saldo { get; set; }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if(value.Length > 1 && value != null)
                {
                    _nome = value;
                }
            }
        }

        public override string ToString()
        {
            return "Conta: " + 
                NumeroConta.ToString() + ", " + 
                "Titular: " + 
                Nome + ", " + 
                "Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture) + "R$.";
        }
    }
}
