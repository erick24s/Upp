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
using CapaEntidades;
namespace Purificadora
{
    public partial class frmProducto : FormBase
    {
        negProducto nproducto = new negProducto();
        public frmProducto()
        {
            InitializeComponent();
        }
        public void ConsultaProducto()
        {
            dgvProducto.DataSource = nproducto.ConsultaProducto();
            dgvProducto.Refresh();
        }
        //List<entProducto> lstproducto = new List<entProducto>();
        private void btnPAgregar_Click(object sender, EventArgs e)
        {
            entProducto eproducto = new entProducto();
            negProducto nproducto = new negProducto();
            eproducto.Nombre = txtPNombre.Text;
            eproducto.Descripcion = txtPDescripcion.Text;
            eproducto.Precio = Convert.ToDecimal(txtpPrecio.Text);
            nproducto.InsertaProducto(eproducto);
            ConsultaProducto();
        }
        //private void btnAGuardar_Click(object sender, EventArgs e)
        //{
        //    entAlmacen ealmacen = new entAlmacen();
        //    negAlmacen nalmacen = new negAlmacen();
        //    ealmacen.Nombre = txtANombre.Text;
        //    ealmacen.Descripcion = txtADescripcion.Text;
        //    ealmacen.Cantidad = Convert.ToInt32(txtACantidad.Text);
        //    nalmacen.InsertaAlmacen(ealmacen);
        //    ConsultaAlmacen();
        //}

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            entProducto eProducto = new entProducto();

            eProducto.idProducto = Convert.ToInt32(dgvProducto.CurrentRow.Cells[0].Value.ToString());

            nproducto.EliminarProducto(eProducto);
            ConsultaProducto();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            negProducto nproducto = new negProducto();
            entProducto eproducto = new entProducto();
            eproducto.idProducto = Convert.ToInt32(dgvProducto.CurrentRow.Cells[0].Value.ToString());
            eproducto.Descripcion = dgvProducto.CurrentRow.Cells[1].Value.ToString();
            eproducto.Precio = Convert.ToDecimal( dgvProducto.CurrentRow.Cells[2].Value.ToString());
          
            nproducto.EditaProducto(eproducto);
            ConsultaProducto();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            ConsultaProducto();
        }
    }
}
