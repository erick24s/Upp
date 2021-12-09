using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidades;
using CapaNegocios;

namespace Purificadora
{
    public partial class formLogin : Form
    {
        entUsuario objeusuario =new entUsuario();   
        negUsuarios objnusuario  = new negUsuarios();
        frmAdmin objfrmprin = new frmAdmin();

        public static string area;
        public static string NomUsuario;
        public static string EstatusAdmin;
        void p_logueo()
        {
            DataTable dtlog = new DataTable();
            objeusuario.Cuenta = txtUsuario.Text;
            objeusuario.Contraseña = txtContraseña.Text;
            dtlog = objnusuario.nUsuario(objeusuario);

           
            if (dtlog.Rows.Count > 0)
            {
                
                MessageBox.Show("bienvenido " + dtlog.Rows[0][1].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //area = dtlog.Rows[0][0].ToString();
                NomUsuario = dtlog.Rows[0][1].ToString();
                EstatusAdmin = dtlog.Rows[0]["EstatusAdmin"].ToString();

                MessageBox.Show(EstatusAdmin);

                objfrmprin.ShowDialog();
                formLogin log = new formLogin();
                log.ShowDialog();

                if (log.DialogResult == DialogResult.OK)
                    Application.Run(new frmAdmin());


                txtContraseña.Clear();
                txtUsuario.Clear();
                this.Close();

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos", "Mendsaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

        }
            
        public formLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string login = string.Format("Select * From Usuario where Cuenta='{0}' AND Contraseña='{1}'", txtUsuario.Text.Trim(), txtContraseña.Text.Trim());
            //DataSet datoE =Conexion.EvaluaUsuario(login);
            //string cuenta = datoE.Tables[].Rows[]["Cuenta"].ToString.Trim();
            //string contra = datoE.Tables[].Rows[]["Contraseña"].ToString.Trim();
            //if (cuenta == txtNombreAcc.text.Trim()

            
            p_logueo();
            
           
        }

        //private void formLogin_FormClosed(object sender, FormClosedEventArgs e)
        //{
            
        //}
    }
}
