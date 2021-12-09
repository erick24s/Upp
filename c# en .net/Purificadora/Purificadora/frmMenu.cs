using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purificadora
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        Form pki = new Form();

        //frmAlmacen frmhijo;
        //frmProducto frmphijo;
        public void MuestraFormulario(string formulario)
        {

            if (pki.Text == "")
            {
                switch (formulario)
                {
                    case "Almacen":
                        {
                            pki = new frmAlmacen();
                            //frmhijo.MdiParent = this;
                            //frmhijo.Show();
                            //frmhijo.WindowState = FormWindowState.Maximized;
                        }
                        break;
                    case "Productos":

                        {
                            pki = new frmProducto();
                            //frmphijo.MdiParent = this;
                            //frmphijo.Show();
                            //frmphijo.WindowState = FormWindowState.Maximized;
                        }
                      
                        break;
                    default: break;
                }
                pki.MdiParent = this;
                pki.Show();
                //pki.WindowState = FormWindowState.Maximized;

            }
            else
                MessageBox.Show("solo puede haber un formulario abierto");
        }
            private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuestraFormulario("Almacen");
            //frmhijo.MdiParent= this;
            //frmhijo.Show();

        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuestraFormulario("Productos");
        }
    }
}
