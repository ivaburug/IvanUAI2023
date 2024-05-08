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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTNMContraseña_Click(object sender, EventArgs e)
        {
            TContraseña.UseSystemPasswordChar = true;
            BTNMContraseña.Text = "Ocultar contraseña";

        }

        private void BTNMContraseña_MouseLeave(object sender, EventArgs e)
        {
            TContraseña.UseSystemPasswordChar = false;
            BTNMContraseña.Text = "Mostrar contraseña";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                if (comboBox1.SelectedItem == "Recursos Humanos")
                {
                    MessageBox.Show("No se puede crear una cuenta de recursos humanos, eso es creado por la empresa, por favor contactar al superovisor");
                }
                else
                {
                    Crear_cuenta CC = new Crear_cuenta();
                    CC.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Seleccionar la categoría para crear una cuenta de este tipo");
            }

        }

        private void BTNIngresar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && TUsuario.Text != "" && TContraseña.Text!="")
            {
                if (comboBox1.SelectedItem == "Recursos Humanos")
                {
                   if(TUsuario.Text=="Admin"&&TContraseña.Text=="Admin")
                    {
                        //Va a buscar los datos cargados en la base de datos y va entrar a el forms de RRHH
                        InterfazRRHH CE = new InterfazRRHH();
                        CE.Show();
                        this.Hide();
                    }
                   else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta por favor contactar con su supervisor");
                    }
                    
                        
                }
                else
                {
                    //Va a buscar los datos cargados en la base de datos y va a entrar a el forms de Clientes
                }
            }
            else
            {
                MessageBox.Show("Completar campos faltantes");
            }
        }
    }
}
