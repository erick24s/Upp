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
    public partial class Ventas : Form
    {
        Panel Panel;

        public Ventas(Panel paramPanel)
        {
            InitializeComponent();
            Panel = paramPanel;
            dgvVentas.Columns.Add("ID", "ID");
            dgvVentas.Columns.Add("Producto", "Producto");
            dgvVentas.Columns.Add("Precio", "Precio");
            dgvVentas.Columns.Add("Cantidad", "Cantidad");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CatProductos objCatProductos = new CatProductos(Panel,this,"Ventas");
            objCatProductos.MdiParent = Panel;
            objCatProductos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ID = tbIDProducto.Text;
            string NombreProducto = tbNombreProducto.Text;
            string Precio = tbPrecioProducto.Text;
            string Cantidad = tbCantidadProducto.Text;
            int CantidadPagar = 0;
            dgvVentas.Rows.Insert(0, ID, NombreProducto, Precio, Cantidad);

            int TotalProductos = dgvVentas.Rows.Count;
            for (int i = 0; i < TotalProductos; i++)
            {
                DataGridViewRow row = dgvVentas.Rows[i];
                //MessageBox.Show(row.Cells[0].Value.ToString() + " " + row.Cells[1].Value.ToString());
                CantidadPagar = CantidadPagar + (int.Parse(row.Cells[2].Value.ToString()) * int.Parse(row.Cells[3].Value.ToString()));
            }

            lblTotalPagar.Text = CantidadPagar.ToString();
            lblTotalProductos.Text = TotalProductos.ToString();


        }
    }
}
