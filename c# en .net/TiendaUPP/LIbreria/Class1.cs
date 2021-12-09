using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LIbreria
{
    public class Herramientas
    {
        public static SqlConnection Conexion = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = Sistemas; User ID = sa; Password = mamadolores");

        public static bool Login(string User, string Clave)
        {
            bool lBandera = false;
            string Query = "SELECT COUNT(*) FROM usuario WHERE cUsuario='" + User + "' AND cClave='" + Clave + "' AND lActivo=1";
            SqlDataAdapter data = new SqlDataAdapter(Query, Conexion);
            Conexion.Open();
            DataTable dt = new DataTable();
            data.Fill(dt);
            if (int.Parse(dt.Rows[0][0].ToString()) == 1)
            {
                lBandera = true;
            }
            Conexion.Close();
            return lBandera;
        }

        public static DataSet BusquedaCatalogo(string Query)
        {
            SqlDataAdapter data = new SqlDataAdapter(Query, Conexion);
            Conexion.Open();
            DataSet DS = new DataSet();
            data.Fill(DS);
            Conexion.Close();
            return DS;
        }

        public static DataSet PoblaData(string Tabla)
        {
            string Query = "SELECT * FROM "+Tabla+" WHERE lActivo = 1";
            //string Query = "SELECT idProducto Producto, cNombreProducto Nombre, cDescripcion Descripcion FROM "+Tabla+" WHERE lActivo = 1";
            SqlDataAdapter data = new SqlDataAdapter(Query,Conexion);
            Conexion.Open();
            DataSet DS = new DataSet();
            data.Fill(DS);
            Conexion.Close();
            return DS;
        }

        public static string GestionaRegistro(string Query)
        {
            string Respuesta;
            try
            {
                SqlCommand cmd = new SqlCommand(Query, Conexion);
                Conexion.Open();
                cmd.ExecuteNonQuery();
                Conexion.Close();
                Respuesta = "ok";
            }
            catch (Exception e)
            {
                Respuesta = e.Message;
            }
            return Respuesta;
        }

    }
}
