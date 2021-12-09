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
    public class negDetalleVenta
    {
        datDetalleventas ddetalleventa = new datDetalleventas();
        public string EditaUsuario(entDetalleVentas edetalleventas)
        {
            return ddetalleventa.EditaDetalleVentas(edetalleventas);
        }
        public DataTable ConsultaUsuario()
        {
            return ddetalleventa.ConsultaDetalleVentas();
        }
        public string InsertaUsuario(entDetalleVentas edetalleventas)
        {
            datDetalleventas ddetalleventa = new datDetalleventas();
            return ddetalleventa.InsertaDetalleVentas(edetalleventas);
        }
    }
}
