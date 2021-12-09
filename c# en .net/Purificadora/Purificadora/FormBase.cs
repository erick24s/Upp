using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaDatos;
namespace Purificadora
{
    public partial class FormBase : Form
    {
        negAlmacen ngeneral = new negAlmacen();
        public FormBase()
        {
            InitializeComponent();
        }
     
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormBase_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
