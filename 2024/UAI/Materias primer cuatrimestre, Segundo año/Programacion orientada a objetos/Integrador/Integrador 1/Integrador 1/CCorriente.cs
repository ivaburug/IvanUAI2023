using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integrador_1
{
    public class CCorriente : Cuentas
    {
		public CCorriente(int codigo, string Fdalta, string Titular, int Saldo): base(codigo, Fdalta, Titular, Saldo)
        {

		}
		public int _Descubirto = 10000;
      
        public int Dscubierto
		{
			get { return _Descubirto; }
			set { _Descubirto = value; }
		}

        public Tarjetaa Tarjetaa
        {
            get => default;
            set
            {
            }
        }
    }
}