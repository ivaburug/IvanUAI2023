using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integrador_1
{
    public class RSocial : Cliente
    {
        public RSocial(string Ape, string nom, int Docu, string Tipe, string calle, int num, int piso, string depto, string fecha, string Tcliente, int ncliente) : base (Ape, nom, Docu, Tipe, calle, num, piso, depto, fecha, Tcliente, ncliente)

        { 
           
        }
        private int _Cuit;

        public int Cuit
        {
            get { return _Cuit; }
            set { _Cuit = value; }
        }

        private string _Responsabe;

        public string Responsable
        {
            get { return _Responsabe; }
            set { _Responsabe = value; }
        }

        private string _Tipo;

        public string Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }



    }

    public class Unipersonal : Cliente
    {
        public Unipersonal(string Ape, string nom, int Docu, string Tipe, string calle, int num, int piso, string depto, string fecha, string Tcliente, int ncliente) : base(Ape, nom, Docu, Tipe, calle, num, piso, depto, fecha, Tcliente, ncliente)
        {
                
        }
    }
}