using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integrador_1
{
	public class Cuentas
	{
		public int _Codigo;

		public int Codigo
		{
			get { return _Codigo; }
			set { _Codigo = value; }
		}

		public string _FAlta;

		public string Falta
		{
			get { return _FAlta; }
			set { _FAlta = value; }
		}

		public string _Titular;

		public string Titular
		{
			get { return _Titular; }
			set { _Titular = value; }
		}

		public int _Saldo;

		public int Saldo
		{
			get { return _Saldo; }
			set { _Saldo = value; }
		}

        public Cuentas(int codigo, string Fdalta, string Titular, int Saldo)
        {
            
        }

    }
}