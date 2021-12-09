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
    public class negAlmacen
    {
        datAlmacen dalmacen = new datAlmacen();
        public string EditaAlmacen(entAlmacen ealmacen)
        {
            return dalmacen.EditaAlmacen(ealmacen);
        }
        public DataTable ConsultaAlmacen()
        {
            return dalmacen.ConsultaAlmacen();
        }
        public string InsertaAlmacen(entAlmacen ealmacen)
        {
            datAlmacen dalmacen = new datAlmacen();
            return dalmacen.InsertaAlmacen(ealmacen);
        }
        public string EliminarAlmacen(entAlmacen eAlmacen)
        {
            return dalmacen.EliminarAlmacen(eAlmacen);
        }
    }
}
