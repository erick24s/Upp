using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace CapaDatos
{
    public class Conexion
    {

        //public static DataSet EvaluaUsuario (string comando)
        //{
        //    SqlConnection Evaluar = new SqlConnection("Data Source Data source=WindowsUpp; initial catalog=pizzeria; integrated security=true");
        //    Evaluar.Open();
        //    DataSet Datos = new DataSet();
        //    SqlDataAdapter DatP = new SqlDataAdapter(comando, Evaluar);
        //    DatP.Fill(Datos);
        //    Evaluar.Close();
        //    return Datos;

        //}

        const string CadenaConexion = @"Data source=WindowsUpp; initial catalog=BasePurificadora; integrated security=true";
        private static readonly SqlConnection conexion = new SqlConnection(CadenaConexion);
        public static SqlConnection AbreConexion()
        {
            try
            {
                conexion.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return conexion;
        }

        public static void CierraConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
