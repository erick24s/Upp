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
   public class datEmpleados
    {

        public string EditaEmpleado(entEmpleado eEmpleado)
        {
            string sDevolver = "";
            var comando = new SqlCommand("dbo.stpEditaEmpleado", Conexion.AbreConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idEmpleado", eEmpleado.idEmpleado);
            comando.Parameters.AddWithValue("@Nombre", eEmpleado.Nombre);
            comando.Parameters.AddWithValue("@Direccion", eEmpleado.Direccion);
            comando.Parameters.AddWithValue("@Telefono", eEmpleado.Telefono);
           

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

        public DataTable ConsultaEmpleado()
        {
            DataTable dtEmpleado = new DataTable();
            SqlCommand comando = new SqlCommand("stpMuestraEmpleado", Conexion.AbreConexion());
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader drEmpleado = comando.ExecuteReader();
            dtEmpleado.Load(drEmpleado);
            Conexion.CierraConexion();
            return dtEmpleado;
        }
        public string InsertaEmpleado(entEmpleado eEmpleado)
        {
            string sDevolver = "";
            var comando = new SqlCommand("dbo.stpCreaEmpleado" , Conexion.AbreConexion());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", eEmpleado.Nombre);
            comando.Parameters.AddWithValue("@Direccion", eEmpleado.Direccion);
            comando.Parameters.AddWithValue("@Telefono", eEmpleado.Telefono);
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
