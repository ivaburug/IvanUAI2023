using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chejolan
{
    public class Persona
    {
		private string _Apellido;

		public string Apellido
		{
			get { return _Apellido; }
			set { _Apellido = value; }
		}

		private string _Nombre;

		public string Nombre
		{
			get { return _Nombre; }
			set { _Nombre = value; }
		}

		private DateTime _Fnac;

		public DateTime FechaNacimiento
		{
			get { return _Fnac; }
			set { _Fnac = value; }
		}


        private List<Teléfono> _Ltel;

        public List<Teléfono> Teléfono
        {
            get { return _Ltel; }
            
        }

        public void agregaTel(Teléfono Tel)
        {
            _Ltel.Add(Tel);
        }

        public Categoría Categoría
        {
            get => default;
            set
            {
            }
        }

        public CorreoE CorreoE
        {
            get => default;
            set
            {
            }
        }
    }
}