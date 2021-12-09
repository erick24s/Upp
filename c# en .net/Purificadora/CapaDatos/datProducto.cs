using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class datProducto
    {
        public string EditaProducto(entProducto eProducto)
        {
            string sDevolver = "";
            var comando = new SqlCommand("dbo.stpEditaProducto", Conexion.AbreConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProducto", eProducto.idProducto);
            comando.Parameters.AddWithValue("@Nombre", eProducto.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", eProducto.Descripcion);
            comando.Parameters.AddWithValue("@Precio", eProducto.Precio);


            try
            {
                sDevolver = comando.ExecuteNonQuery().ToString();

            }
            catch (Exception ex)
            {
                sDevolver = ex.Message;
            }
            Conexion.CierraConexion();
            return sDevolver;
        }

        public DataTable ConsultaProducto()
        {
            DataTable dtProducto = new DataTable();
            SqlCommand comando = new SqlCommand("stpMuestraProducto", Conexion.AbreConexion());
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader drProducto = comando.ExecuteReader();
            dtProducto.Load(drProducto);
            Conexion.CierraConexion();
            return dtProducto;
        }
        public string InsertaProducto(entProducto eProducto)
        {
            string sDevolver = "";
            var comando = new SqlCommand("dbo.stpCreaProducto", Conexion.AbreConexion());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProducto", eProducto.idProducto);
            comando.Parameters.AddWithValue("@Nombre", eProducto.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", eProducto.Descripcion);
            comando.Parameters.AddWithValue("@Precio", eProducto.Precio);
            try
            {
                sDevolver = comando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                sDevolver = ex.Message;
            }
            Conexion.CierraConexion();
            return sDevolver;
        }
        public string EliminarProducto(entProducto eProducto)
        {
            string sDevolver = "";
            var comando = new SqlCommand("dbo.stpEliminarProducto", Conexion.AbreConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProducto", eProducto.idProducto);

            try
            {
                sDevolver = comando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                sDevolver = ex.Message;
            }
            Conexion.CierraConexion();
            return sDevolver;

        }

    }
}
