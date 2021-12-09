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
    public class datCliente
    {
        public string EditaCliente(entCliente ecliente)
        {
            string sDevolver = "";
            var comando = new SqlCommand("dbo.stpEditaCliente", Conexion.AbreConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idcliente", ecliente.idCliente);
            comando.Parameters.AddWithValue("@Nombre", ecliente.Nombre);
            comando.Parameters.AddWithValue("@Direccion", ecliente.Direccion);
            comando.Parameters.AddWithValue("@Telefono", ecliente.Telefono);

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
        public DataTable ConsultaClientes()
        {
            DataTable dtClientes = new DataTable();
            SqlCommand comando = new SqlCommand("stpMuestraCliente", Conexion.AbreConexion());
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader drClientes = comando.ExecuteReader();
            dtClientes.Load(drClientes);
            Conexion.CierraConexion();
            return dtClientes;
        }
        public string InsertaClientes(entCliente eCliente)
        {
            string sDevolver = "";
            var comando = new SqlCommand("dbo.stpCreaCliente", Conexion.AbreConexion());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", eCliente.Nombre);
            comando.Parameters.AddWithValue("@Direccion", eCliente.Direccion);
            comando.Parameters.AddWithValue("@Telefono", eCliente.Telefono);
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
