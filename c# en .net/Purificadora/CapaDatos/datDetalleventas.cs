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
    public  class datDetalleventas
    {
        public string EditaDetalleVentas(entDetalleVentas edetalleVentas)
        {
            string sDevolver = "";
            var comando = new SqlCommand("dbo.stpEditaDetalleVentas", Conexion.AbreConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idVenta", edetalleVentas.idDetalleVenta);
            comando.Parameters.AddWithValue("@idProducto", edetalleVentas.idProducto);
            comando.Parameters.AddWithValue("@Cantidad", edetalleVentas.Cantidad);
            comando.Parameters.AddWithValue("@Total", edetalleVentas.Total);

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
        public DataTable ConsultaDetalleVentas()
        {
            DataTable dtDetalleVentas = new DataTable();
            SqlCommand comando = new SqlCommand("stpMuestraDetalleVentas", Conexion.AbreConexion());
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader drDetalleVentas = comando.ExecuteReader();
            dtDetalleVentas.Load(drDetalleVentas);
            Conexion.CierraConexion();
            return dtDetalleVentas;
        }
        public string InsertaDetalleVentas(entDetalleVentas edetalleVentas)
        {
            string sDevolver = "";
            var comando = new SqlCommand("dbo.stpCreaDestalleVentas", Conexion.AbreConexion());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProducto", edetalleVentas.idProducto);
            comando.Parameters.AddWithValue("@Cantidad", edetalleVentas.Cantidad);
            comando.Parameters.AddWithValue("@Total", edetalleVentas.Total);
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
