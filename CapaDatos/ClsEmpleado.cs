using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto12.CapaDatos
{
    public class ClsEmpleado
    {
        public int IdEmpleado { get; set; }
        public int IdCargo { get; set; }
        public int Cedula { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNac { get; set; }
        public string Direccion  { get; set; }
        public string EstadoCivil { get; set; }

        public ClsEmpleado(int idEmpleado, int idCargo, int cedula, string apellidos, string nombres, string sexo, DateTime fechaNac, string direccion, string estadoCivil)
        {
            IdEmpleado = idEmpleado;
            IdCargo = idCargo;
            Cedula = cedula;
            Apellidos = apellidos ?? throw new ArgumentNullException(nameof(apellidos));
            Nombres = nombres ?? throw new ArgumentNullException(nameof(nombres));
            Sexo = sexo ?? throw new ArgumentNullException(nameof(sexo));
            FechaNac = fechaNac;
            Direccion = direccion ?? throw new ArgumentNullException(nameof(direccion));
            EstadoCivil = estadoCivil ?? throw new ArgumentNullException(nameof(estadoCivil));
        }

        public ClsEmpleado() { }
    }
}