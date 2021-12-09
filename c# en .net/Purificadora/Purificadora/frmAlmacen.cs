using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;
using CapaDatos;
namespace Purificadora
{
    public partial class frmAlmacen : FormBase
    {

        negAlmacen nalmacen = new negAlmacen();
        public frmAlmacen()
        {
            InitializeComponent();
        }
        public void ConsultaAlmacen()
        {
            dgvAlmacen.DataSource = nalmacen.ConsultaAlmacen();
            dgvAlmacen.Refresh();
        }
        private void btnAGuardar_Click(object sender, EventArgs e)
        {
            entAlmacen ealmacen = new entAlmacen();
            negAlmacen nalmacen = new negAlmacen();
            ealmacen.Nombre = txtANombre.Text;
            ealmacen.Descripcion = txtADescripcion.Text;
            ealmacen.Cantidad = Convert.ToInt32(txtACantidad.Text);
            nalmacen.InsertaAlmacen(ealmacen);
            ConsultaAlmacen();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            entAlmacen eAlmacen = new entAlmacen();

            eAlmacen.idAlmacen = Convert.ToInt32(dgvAlmacen.CurrentRow.Cells[0].Value.ToString());

            nalmacen.EliminarAlmacen(eAlmacen);
            ConsultaAlmacen();
        }

        private void frmAlmacen_Load(object sender, EventArgs e)
        {
            ConsultaAlmacen();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            entAlmacen ealmacen = new entAlmacen();
            negAlmacen nalmacen = new negAlmacen();
            ealmacen.idAlmacen = Convert.ToInt32(dgvAlmacen.CurrentRow.Cells[0].Value.ToString());
            ealmacen.Nombre = dgvAlmacen.CurrentRow.Cells[1].Value.ToString();
            ealmacen.Descripcion = dgvAlmacen.CurrentRow.Cells[2].Value.ToString();
            ealmacen.Cantidad = Convert.ToInt32(dgvAlmacen.CurrentRow.Cells[3].Value.ToString());

            nalmacen.EditaAlmacen(ealmacen);
        }
    }
}
