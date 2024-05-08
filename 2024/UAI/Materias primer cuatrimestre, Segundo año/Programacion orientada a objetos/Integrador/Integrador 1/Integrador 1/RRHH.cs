using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integrador_1
{
    public class RRHH : Persona
    {
        public RRHH(string Ape, string nom, int Docu, string Tipe) : base (Ape, nom, Docu, Tipe)
        {
            
        }

        public int _Legajo;

		public int Legajo
		{
			get { return _Legajo; }
			set { _Legajo = value; }
		}

		public string _ACargo;

		public string ACargo
		{
			get { return _ACargo; }
			set { _ACargo = value; }
		}

		public string _FechaIngreso;

		public string FechaIngreso
		{
			get { return _FechaIngreso; }
			set { _FechaIngreso = value; }
		}



	}
}