using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;
using System.Data;


namespace CapaNegocios
{
    public class negUsuarios
    {
        datUsuarios objd = new datUsuarios();
        datUsuarios dUsuario = new datUsuarios();

        public DataTable nUsuario(entUsuario obje)
        {
            return objd.dUser(obje); 
        }


        
        public string EditaUsuario(entUsuario eUsuario)
        {
            return dUsuario.EditaUsuario(eUsuario);
        }
        public DataTable ConsultaUsuario()
        {
            return dUsuario.ConsultaUsuario();
        }
        public string InsertaUsuario(entUsuario eUsuario)
        {
            datUsuarios dUsuario = new datUsuarios();
            return dUsuario.InsertaUsuario(eUsuario);
        }

        public string EliminarUsuario(entUsuario eUsuario)
        {
            return dUsuario.EliminarUsuario(eUsuario);
        }
    }



}

