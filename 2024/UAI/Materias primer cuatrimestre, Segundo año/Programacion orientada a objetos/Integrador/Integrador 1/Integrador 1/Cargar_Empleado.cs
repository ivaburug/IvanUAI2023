using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador_1
{
    public partial class Cargar_Empleado : Form
    {
        public Cargar_Empleado()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNCargar_Click(object sender, EventArgs e)
        {
            if (ComboDocu.SelectedIndex != -1 && TNDocu.Text != "" && TNombrePila.Text != "" && TApe.Text != "" && Tlegajo.Text != "" && TACargoD.Text != "" && Tarea.Text != "" && FIngreso.Visible)
            {
                //agregar a algún lado (Ya ta linea 47)
                //si todo esta cool
                MessageBox.Show("EL EMPLEADO FUE CARGADO CON EXITO");
                string Datos = Tlegajo.Text + ";" + TNombrePila.Text + ";" + TApe.Text + ";" + TNDocu.Text + ";"+ComboDocu.SelectedItem.ToString() + ";" + TACargoD.Text + ";" + Tarea.Text + ";" +FIngreso;
                CargarDatos(Datos);
                this.Close();
                
            }

            
        }

        private void CargarDatos(string Datos)
        {
            FileStream fs = new FileStream("Trabajadores.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs); 
            sw.Write(Datos);
            sw.Close();
            fs.Close();
        }
    }
}
