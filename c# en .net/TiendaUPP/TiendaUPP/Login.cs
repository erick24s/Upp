using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIbreria;

namespace TiendaUPP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario = tbUsuario.Text;
            string Clave = tbClave.Text;

            if (Herramientas.Login(Usuario, Clave))
            {
                Panel objPanel = new Panel();
                objPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos incorrectos. Intenta de nuevo!!!");
            }
        }
    }
}
