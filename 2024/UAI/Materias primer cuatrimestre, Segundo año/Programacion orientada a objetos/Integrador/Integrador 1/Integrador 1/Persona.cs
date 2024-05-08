using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace Integrador_1
{
    public abstract class Persona
    {

        public string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string _Apellido;

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }


        public int _Doc;

        public int Doc
        {
            get { return _Doc; }
            set { _Doc = value; }
        }

        public string _Tipo;

        public string Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }

        public Persona(string Ape, string nom, int Docu, string Tipe)
        {

        }

        public Cuentas Cuentas
        {
            get => default;
            set
            {
            }
        }
    }
}