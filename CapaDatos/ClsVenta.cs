using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Profile;

namespace proyecto12.CapaDatos
{
    public class ClsVenta
    {
        public int IdVenta { get; set; }
        public int IdEmpleado { get; set; }
        public int IdCliente { get; set; }
        public int Serie { get; set; }
        public int NroDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public DateTime FechaVenta { get; set; }
        public float Total { get; set; }

        public ClsVenta(int idVenta, int idEmpleado, int idCliente, int serie, int nroDocumento, string tipoDocumento, DateTime fechaVenta, float total)
        {
            IdVenta = idVenta;
            IdEmpleado = idEmpleado;
            IdCliente = idCliente;
            Serie = serie;
            NroDocumento = nroDocumento;
            TipoDocumento = tipoDocumento;
            FechaVenta = fechaVenta;
            Total = total;
        }

        public ClsVenta() { }
    }
}