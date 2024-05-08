using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integrador_1
{
    public class Cliente : Persona
    {
        public Cliente(string Ape, string nom, int Docu, string Tipe) : base (Ape,nom, Docu, Tipe)
        {
            
        }
        public string _Calle;

        public string Calle
        {
            get { return _Calle; }
            set { _Calle = value; }
        }

        public int _Ncalle;

        public int Ncalle
        {
            get { return _Ncalle; }
            set { _Ncalle = value; }
        }

        public int _Piso;

        public int Psio
        {
            get { return _Piso; }
            set { _Piso = value; }
        }

        public string _Depto;

        public string Depto
        {
            get { return _Depto; }
            set { _Depto = value; }
        }

        public string _Fecha;

        public string Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }

        public string _Tcliente;

        public string TCLiente
        {
            get { return _Tcliente; }
            set { _Tcliente = value; }
        }

        public int _NCliente;

        public int Ncliente
        {
            get { return _NCliente; }
            set { _NCliente = value; }
        }

        public Cliente(string Ape, string nom, int Docu, string Tipe, string calle, int num, int piso, string depto, string fecha, string Tcliente, int ncliente) : base(Ape, nom, Docu, Tipe)
        {
            
        }

    }
}