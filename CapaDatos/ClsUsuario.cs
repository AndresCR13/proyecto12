using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace proyecto12.CapaDatos
{
    public  class ClsUsuario
    {
        public static int IdUsuario { get; set; }
        public static int IdEmpleado { get; set; }
        public static string Usuario { get; set; }
        public static string Contrasenya { get; set; }
        public ClsUsuario() { }

        public ClsUsuario(int idUsuario, int idEmpleado, string usuario, string contrasenya)
        {
            IdUsuario = idUsuario;
            IdEmpleado = idEmpleado;
            Usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
            Contrasenya = contrasenya ?? throw new ArgumentNullException(nameof(contrasenya));
        }
    }
}