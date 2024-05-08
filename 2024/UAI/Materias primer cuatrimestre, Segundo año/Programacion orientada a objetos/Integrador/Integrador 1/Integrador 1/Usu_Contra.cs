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
    public partial class Usu_Contra : Form
    {
        public Usu_Contra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Contra1;
            string Contra2;
            Contra1 = TContra1.Text;
            Contra2 = TContra2.Text;
            if(Contra1==Contra2)
            {
                MessageBox.Show("La cuenta ha sido creada con exito :)");
                //Abre la interfaz de usuario Guardando el dato de usuario y contraseña para corroborarlo en el inicio de sesion
            }
            else 
            {
                MessageBox.Show("Las contraseñas no coinciden :(");
            }
        }

        private void TUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
