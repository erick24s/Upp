using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Purificadora
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
       
        //if ( estat)
        //    {
        //        }


        //private void pictureBox2_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void frmAdmin_Load(object sender, EventArgs e)
        {
          
           //txtNom.Text = NomUsuario;
           // txtUsuarioAdmin.Text = log.EstatusAdmin;
            //if (formLogin.EstatusAdmin == "0")
            //   {
            //       btnCambiarpass.Enabled = true;
            //       btnCerrarSesion.Enabled = true;
            //       btnUser.Enabled = false;
            //       BtnMenu.Enabled = false;
            //   }
            //   else if (formLogin.EstatusAdmin == "1")
            //   {
            //       btnCambiarpass.Enabled = true;
            //       btnCerrarSesion.Enabled = true;
            //       btnUser.Enabled = false;
            //       BtnMenu.Enabled = false;
            //   }


        }

        //if (formLogin.EstatusAdmin == "0")
        //   {
        //       btnCambiarpass.Enabled = true;
        //       btnCerrarSesion.Enabled = true;
        //       btnUser.Enabled = false;
        //       BtnMenu.Enabled = false;
        //   }
        //   else if (formLogin.EstatusAdmin == "1")
        //   {
        //       btnCambiarpass.Enabled = true;
        //       btnCerrarSesion.Enabled = true;
        //       btnUser.Enabled = false;
        //       BtnMenu.Enabled = false;
        //   }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmusUario  fusuario    = new frmusUario();
            fusuario.ShowDialog();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            
            frmMenu objfrmmenu = new frmMenu();
           //this.Hide();
            objfrmmenu.Show();
           
        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) ==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmAdmin_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
