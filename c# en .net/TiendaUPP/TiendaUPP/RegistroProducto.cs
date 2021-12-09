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
    public partial class RegistroProducto : Form
    {
        CatProductos PapaCatProductos;
        int ID;

        public RegistroProducto(CatProductos paramCatProductos, int paramID)
        {
            InitializeComponent();
            PapaCatProductos = paramCatProductos;
            ID = paramID;

            if (ID > 0) //MODIFICACION
            {
                this.Text = "Modificar Producto";
                this.btnGuardar.Text = "Modificar";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query;
            if(ID > 0)
            {
                Query = "UPDATE producto SET cNombreProducto='" + tbNombre.Text + "', cDescripcion='" + tbDescripcion.Text + "' WHERE idProducto="+ID;
            }
            else
            {
                Query = "INSERT INTO producto (cNombreProducto,idUnidadMedida,idProveedor,cDescripcion,lActivo) VALUES('" + tbNombre.Text + "',1,1,'" + tbDescripcion.Text + "',1)";
            }

            string Respuesta = Herramientas.GestionaRegistro(Query);
            if ( Respuesta == "ok")
            {
                MessageBox.Show("¡Registro Guardado Correctamente!");
                DataSet DS = Herramientas.PoblaData("producto");
                PapaCatProductos.dgvProductos.DataSource = DS.Tables[0];
            }
            else
            {
                MessageBox.Show(Respuesta);
            }
            
        }
    }
}
