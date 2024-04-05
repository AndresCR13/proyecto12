using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto12.CapaDatos
{
    public class ClsDetalleVenta
    {
        public int IdDetalleVen { get; set; }
        public int IdCategoria { get; set; }
        public int IdVenta { get; set;}
        public int Cantidad { get; set; }
        public float PrecioUnitario { get; set; }
        public float Igv { get; set; }
        public float SubTotal { get; set; }

        public ClsDetalleVenta(int idDetalleVen, int idCategoria, int idVenta, int cantidad, float precioUnitario, float igv, float subTotal)
        {
            IdDetalleVen = idDetalleVen;
            IdCategoria = idCategoria;
            IdVenta = idVenta;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Igv = igv;
            SubTotal = subTotal;
        }
        public ClsDetalleVenta() { }
    }
}