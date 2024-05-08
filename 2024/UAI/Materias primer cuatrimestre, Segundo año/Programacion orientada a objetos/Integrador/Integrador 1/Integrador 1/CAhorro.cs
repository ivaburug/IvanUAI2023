using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integrador_1
{
    public class CAhorro : Cuentas
    {
        public CAhorro(int codigo, string Fdalta, string Titular, int Saldo) : base(codigo, Fdalta, Titular, Saldo)
        {
            
        }
        private int _Min = 10000;

        public int Minimo
        {
            get { return _Min; }
            set { _Min = value; }
        }

    }
}