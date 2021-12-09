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
    public class negVenta
    {
       datVenta dventa = new datVenta();
        public string EditaVenta(entVenta eventa)
        {
            return dventa.EditaVenta(eventa);
        }
        public DataTable ConsultaVenta()
        {
            return dventa.ConsultaVenta();
        }
        public string InsertaVenta(entVenta eventa)
        {
            datVenta dventa = new datVenta();
            return dventa.InsertaVenta(eventa);
        }
    }
}
