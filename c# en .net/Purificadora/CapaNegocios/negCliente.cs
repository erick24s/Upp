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
    public class negCliente
    {
        datCliente dcliente = new datCliente();
        public string EditaCliente(entCliente eclientes)
        {
            return dcliente.EditaCliente(eclientes);
        }
        public DataTable ConsultaClientes()
        {
            return dcliente.ConsultaClientes();
        }
        public string InsertaUsuario(entCliente eclientes)
        {
            datCliente dClientes = new datCliente();
            return dClientes.InsertaClientes(eclientes);
        }
    }
}
