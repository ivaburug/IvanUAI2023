using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador_1
{
    public partial class InterfazRRHH : Form
    {
        public InterfazRRHH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cargar_Empleado CE = new Cargar_Empleado();
            CE.Show();
            
        }
    }
}
