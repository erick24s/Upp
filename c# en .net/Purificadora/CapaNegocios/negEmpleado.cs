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
    public class negEmpleado
    {
        datEmpleados dempleado = new datEmpleados();
        public string EditaUsuario(entEmpleado eempleado)
        {
            return dempleado.EditaEmpleado(eempleado);
        }
        public DataTable ConsultaUsuario()
        {
            return dempleado.ConsultaEmpleado();
        }
        public string InsertaEmpleado(entEmpleado eempleado)
        {
            datEmpleados dempleado = new datEmpleados();
            return dempleado.InsertaEmpleado(eempleado);
        }
    }
}
