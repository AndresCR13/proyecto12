using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto12.CapaDatos
{
    public class ClsProducto
    {
        public int IdProdructo { get; set; }
        public int IdCategoria { get; set; }
        public string Nombre { get; set;}
        public string Marca { get; set;}
        public int Stock { get; set;}
        public int PrecioVenta { get; set;}
        public int PrecioCompra { get; set;}
        public DateTime FechaVencimiento { get; set; }

        public ClsProducto(int idProdructo, int idCategoria, string nombre, string marca, int stock, int precioVenta, int precioCompra, DateTime fechaVencimiento)
        {
            IdProdructo = idProdructo;
            IdCategoria = idCategoria;
            Nombre = nombre;
            Marca = marca;
            Stock = stock;
            PrecioVenta = precioVenta;
            PrecioCompra = precioCompra;
            FechaVencimiento = fechaVencimiento;
        }
        public ClsProducto() { }
    }
}