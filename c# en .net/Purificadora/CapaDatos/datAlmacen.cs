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
    public class datAlmacen
    {
        public string EditaAlmacen(entAlmacen ealmacen)
        {
            string sDevolver = "";
            var comando = new SqlCommand("dbo.stpEditaAlmacen", Conexion.AbreConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idAlmacen", ealmacen.idAlmacen);
            comando.Parameters.AddWithValue("@Nombre", ealmacen.Nombre);
            comando.Parameters.AddWithValue("@Descripcio", ealmacen.Descripcion);
            comando.Parameters.AddWithValue("@Cantidad", ealmacen.Cantidad);

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
        public DataTable ConsultaAlmacen()
        {
            DataTable dtalmacen = new DataTable();
            SqlCommand comando = new SqlCommand("stpMuestraAlmacen", Conexion.AbreConexion());
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader dralmacen = comando.ExecuteReader();
            dtalmacen.Load(dralmacen);
            Conexion.CierraConexion();
            return dtalmacen;
        }
        public string InsertaAlmacen(entAlmacen ealmacen)
        {
            string sDevolver = "";
            var comando = new SqlCommand("dbo.stpCreaAlmacen", Conexion.AbreConexion());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", ealmacen.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", ealmacen.Descripcion);
            comando.Parameters.AddWithValue("@Cantidad", ealmacen.Cantidad);
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

        public string EliminarAlmacen(entAlmacen eAlmacen)
        {
            string sDevolver = "";
            var comando = new SqlCommand("dbo.stpEliminarAlmacen", Conexion.AbreConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idAlmacen", eAlmacen.idAlmacen);

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
