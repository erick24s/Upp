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
    public partial class frmusUario : FormBase
    {
        negUsuarios nusuario = new negUsuarios();
        public frmusUario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  

        }
        public void ConsultaUsurio()
        {
            dgvUsuario.DataSource = nusuario.ConsultaUsuario();
            dgvUsuario.Refresh();
        }

        private void frmusUario_Load(object sender, EventArgs e)
        {
            ConsultaUsurio();
        }
        List<entUsuario> lstUsuario = new List<entUsuario>();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            entUsuario eusuario = new entUsuario();
            negUsuarios nusuario = new negUsuarios();
            eusuario.Nombre = txtUNombre.Text;
            eusuario.Cuenta = txtUCuenta.Text;
            eusuario.Contraseña = txtUContraseña.Text;
            eusuario.EstatusAdmin = txtUEstatus.Text;
            nusuario.InsertaUsuario(eusuario);
            ConsultaUsurio();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            entUsuario eusuario = new entUsuario();
            eusuario.idUsuario = Convert.ToInt32(dgvUsuario.CurrentRow.Cells[0].Value.ToString());
            eusuario.Nombre = dgvUsuario.CurrentRow.Cells[1].Value.ToString();
            eusuario.Cuenta = dgvUsuario.CurrentRow.Cells[2].Value.ToString();
            eusuario.Contraseña = dgvUsuario.CurrentRow.Cells[3].Value.ToString();

            nusuario.EditaUsuario(eusuario);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            entUsuario eUsuario = new entUsuario();

            eUsuario.idUsuario = Convert.ToInt32(dgvUsuario.CurrentRow.Cells[0].Value.ToString());

            nusuario.EliminarUsuario(eUsuario);
            ConsultaUsurio();


        }
    }
}
