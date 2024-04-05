using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto12.CapaDatos
{
    public class ClsCargo
    {
        public static int IdCargo { get; set; }
        public static string Descripcion { get; set; }
        public ClsCargo() { }

        public ClsCargo(int idCargo, string descripcion)
        {
            IdCargo = idCargo;
            Descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
        }
    }
}