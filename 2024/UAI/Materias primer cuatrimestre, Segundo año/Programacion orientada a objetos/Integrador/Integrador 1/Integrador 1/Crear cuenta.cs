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
    public partial class Crear_cuenta : Form
    {
        public Crear_cuenta()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Crear_cuenta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn F1 = new LogIn();
            F1.Show();
            this.Close();
        }

        private void BTNRegistrarme_Click(object sender, EventArgs e)
        {
            if(ComboDocu.SelectedIndex!=-1&&TNDocu.Text!=""&&TNombrePila.Text!=""&&TApe.Text!=""&&FNacimiento.Visible&&ComboCliente.SelectedIndex!=-1&&TCalle.Text!=""&&TCNumero.Text!="")
            {
                //Almacenar los datops en algún lado
                if (ComboCliente.SelectedItem == "RSocial")
                {
                    Rasocial F1 = new Rasocial();
                    F1.Show();
                    this.Close();
                }
                Usu_Contra UC = new Usu_Contra();
                UC.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Completar campos faltantes");
            }
        }

        private void FNacimiento_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
