using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaUPP
{
    public partial class Panel : Form
    {
        Ventas Ventas;
        public Panel()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatProductos objCatProductos = new CatProductos(this,Ventas,"Panel");
            objCatProductos.MdiParent = this;
            objCatProductos.Show();
        }

        private void Panel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Ventas ObjVentas = new Ventas(this);
            ObjVentas.MdiParent = this;
            ObjVentas.Show();
        }
    }
}
