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
    public  class datVenta
    {

        

           
            public string EditaVenta(entVenta eVentas)
            {
                string sDevolver = "";
                var comando = new SqlCommand("dbo.stpEditaVentas", Conexion.AbreConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idVentas", eVentas.idVentas);
                comando.Parameters.AddWithValue("@idCliente", eVentas.idCliente);
                comando.Parameters.AddWithValue("@Fecha", eVentas.Fecha);
               

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

            public DataTable ConsultaVenta()
            {
                DataTable dtVentas = new DataTable();
                SqlCommand comando = new SqlCommand("stpMuestraVentas", Conexion.AbreConexion());
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataReader drClientes = comando.ExecuteReader();
                dtVentas.Load(drClientes);
                Conexion.CierraConexion();
                return dtVentas;
            }
            public string InsertaVenta(entVenta eVentas)
            {
                string sDevolver = "";
                var comando = new SqlCommand("dbo.stpCreaVentas", Conexion.AbreConexion());
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idVentas", eVentas.idVentas);
                comando.Parameters.AddWithValue("@idCliente", eVentas.idCliente);
                comando.Parameters.AddWithValue("@Fecha", eVentas.Fecha);
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
