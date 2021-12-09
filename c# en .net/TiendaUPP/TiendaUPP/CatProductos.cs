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
    public partial class CatProductos : Form
    {
        Panel PapaPanel;
        Ventas pVentas;
        DataSet DS;

        public CatProductos(Panel paramPanel, Ventas paramVentas, string Modulo)
        {
            InitializeComponent();
            DS = Herramientas.PoblaData("producto");
            dgvProductos.DataSource = DS.Tables[0];
            PapaPanel = paramPanel;
            pVentas = paramVentas;

            if(Modulo == "Ventas")
            {
                btnAgregarProducto.Visible = true;
            }
            else
            {
                btnAgregarProducto.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroProducto objRegistroProducto = new RegistroProducto(this,0);
            objRegistroProducto.MdiParent = PapaPanel;
            objRegistroProducto.Show();
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int RI = e.RowIndex;
            DataGridViewRow Row = dgvProductos.Rows[RI];
            int ID = int.Parse(Row.Cells[0].Value.ToString());
            RegistroProducto objRegistroProducto = new RegistroProducto(this,ID);
            objRegistroProducto.MdiParent = PapaPanel;
            objRegistroProducto.Show();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(tbBuscarProducto.Text);
            string Busqueda = tbBuscarProducto.Text;
            if (Busqueda.Length > 2)
            {
                string Query = "SELECT * FROM producto WHERE (cNombreProducto LIKE '%" + Busqueda + "%' OR cDescripcion LIKE '%" + Busqueda + "%') AND lActivo = 1";
                DS = Herramientas.BusquedaCatalogo(Query);
                dgvProductos.DataSource = DS.Tables[0];
            }
            if (e.KeyCode == Keys.Escape)
            {
                DS = Herramientas.PoblaData("producto");
                dgvProductos.DataSource = DS.Tables[0];
                tbBuscarProducto.Text = "";
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dgvProductos.SelectedRows[0].Cells[1].Value.ToString());          

            pVentas.tbIDProducto.Text = dgvProductos.SelectedRows[0].Cells[0].Value.ToString();
            pVentas.tbPrecioProducto.Text = dgvProductos.SelectedRows[0].Cells[6].Value.ToString();
            pVentas.tbNombreProducto.Text = dgvProductos.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
