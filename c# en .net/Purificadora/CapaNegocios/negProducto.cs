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
    public class negProducto
    {
        datProducto dproducto = new datProducto();
        public string EditaProducto(entProducto eproducto)
        {
            return dproducto.EditaProducto(eproducto);
        }
        public DataTable ConsultaProducto()
        {
            return dproducto.ConsultaProducto();
        }
        public string InsertaProducto(entProducto eproducto)
        {
            datProducto dproducto = new datProducto();
            return dproducto.InsertaProducto(eproducto);
        }
        public string EliminarProducto(entProducto eProducto)
        {
            return dproducto.EliminarProducto(eProducto);
        }
    }
}
