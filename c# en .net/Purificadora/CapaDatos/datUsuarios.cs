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
    public  class datUsuarios

    {
        
        public DataTable dUser (entUsuario obje)
        {
            //DataTable dtClientes = new DataTable();
            SqlCommand comando = new SqlCommand("stpLogueo", Conexion.AbreConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Cuenta", obje.Cuenta);
            comando.Parameters.AddWithValue("Contraseña", obje.Contraseña);
            //SqlDataReader drClientes = comando.ExecuteReader();
            //dtClientes.Load(drClientes);
            SqlDataAdapter dA = new SqlDataAdapter(comando);
            DataTable dtClientes2 = new DataTable();
            dA.Fill(dtClientes2);
            Conexion.CierraConexion();
            return dtClientes2;
        }
        public string EditaUsuario(entUsuario eUsuario)
        {
            string sDevolver = "";
            var comando = new SqlCommand("dbo.stpEditaUsuario", Conexion.AbreConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idUsuario", eUsuario.idUsuario);
            comando.Parameters.AddWithValue("@Nombre", eUsuario.Nombre);
            comando.Parameters.AddWithValue("@Cuenta", eUsuario.Cuenta);
            comando.Parameters.AddWithValue("@Contraseña", eUsuario.Contraseña);
            //comando.Parameters.AddWithValue("@idArea", eUsuario.idArea);
            //comando.Parameters.AddWithValue("@idEmpleado", eUsuario.idEmpleado);
            comando.Parameters.AddWithValue("@EstatusAdmin", eUsuario.EstatusAdmin);

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

        public DataTable ConsultaUsuario()
        {
            DataTable dtClientes = new DataTable();
            SqlCommand comando = new SqlCommand("stpMuestraUsuario", Conexion.AbreConexion());
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader drClientes = comando.ExecuteReader();
            dtClientes.Load(drClientes);
            Conexion.CierraConexion();
            return dtClientes;
        }
        public string InsertaUsuario(entUsuario eUsuario)
        {
            string sDevolver = "";
            var comando = new SqlCommand("dbo.stpCreaUsuario", Conexion.AbreConexion());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", eUsuario.Nombre);
            comando.Parameters.AddWithValue("@Cuenta", eUsuario.Cuenta);
            comando.Parameters.AddWithValue("@Contraseña", eUsuario.Contraseña);
            //comando.Parameters.AddWithValue("@idArea", eUsuario.idArea);
            //comando.Parameters.AddWithValue("@idEmpleado", eUsuario.idEmpleado);
            comando.Parameters.AddWithValue("@EstatusAdmin", eUsuario.EstatusAdmin);
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
        //public DataTable ListarMarcas()
        //{
        //    DataTable Tabla = new DataTable();
        //    Comando.Connection = Conexion.AbreConexion();
        //    Comando.CommandText = "ListarMarcas";
        //    Comando.CommandType = CommandType.StoredProcedure;
        //    LeerFilas = Comando.ExecuteReader();
        //    Tabla.Load(LeerFilas);
        //    LeerFilas.Close();
        //    Conexion.CerrarConexion();
        //    return Tabla;
        //}

        public string EliminarUsuario(entUsuario eUsuario)
        {
            string sDevolver = "";
            var comando = new SqlCommand("dbo.stpEliminarUsuario", Conexion.AbreConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idUsuario", eUsuario.idUsuario);

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
