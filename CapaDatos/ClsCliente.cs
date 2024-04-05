using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace proyecto12.CapaDatos
{
    public class ClsCliente
    {
        public static int IdCliente { get; set; }
        public static int Cedula { get; set; }
        public static string Apellidos { get; set; }
        public static string Nombre { get; set;}
        public static string Direccion  { get; set;}
        public  static int Telefono { get; set; }

        public ClsCliente(int idCliente, int cedula, string apellidos, string nombre, string direccion, int telefono)
        {
            IdCliente = idCliente;
            Cedula = cedula;
            Apellidos = apellidos ?? throw new ArgumentNullException(nameof(apellidos));
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Direccion = direccion ?? throw new ArgumentNullException(nameof(direccion));
            Telefono = telefono;
        }
        public ClsCliente() { }

    }
}