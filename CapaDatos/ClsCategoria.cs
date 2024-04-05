using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto12.CapaDatos
{
    public class ClsCategoria
    {
        public static int IdCategoria { get; set; }
        public static string Descripcion { get; set; }

        public ClsCategoria(int idCategoria, string descripcion)
        {
            IdCategoria = idCategoria;
            Descripcion = descripcion;
        }
        public ClsCategoria() { }
    }
}