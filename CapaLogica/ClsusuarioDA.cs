using Microsoft.Win32;
using proyecto12.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace proyecto12.CapaLogica
{
    public class ClsusuarioDA
    {
        //public static int ValidarLogin (string username, string password)
        //{
        //    ClsUsuario.Usuario = username;
        //    ClsUsuario.Contrasenya = password;
        //    int resultado =0;

        //    String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        //    SqlConnection conexion = new SqlConnection(s);
        //    conexion.Open();
        //    SqlCommand comando = new SqlCommand("SELECT IdUsuario,IdEmpleado,Usuario,Contraseña FROM Usuario WHERE Usuario = '" + username + "'" +
        //        SqlDataReader registro = comando.ExecuteReader);

        //    if (registro.Read())
        //    {
        //        ClsUsuario.Usuario = registro[2].ToString();
        //        resultado = 1;
        //    }
        //    else
        //    { 
        //        resultado = -1;
        //    }
        //    return resultado;

        //} 
        public static int ValidarLogin(string username, string password)
        {
            ClsUsuario.Usuario = username;
            ClsUsuario.Contrasenya = password;
            int resultado = 0;

            try
            {
                // Se obtiene la cadena de conexión del archivo de configuración
                String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

                // Se crea y abre la conexión a la base de datos
                using (SqlConnection conexion = new SqlConnection(s))
                {
                    conexion.Open();

                    // Se prepara la consulta SQL parametrizada para evitar inyección SQL
                    string query = "SELECT , Usuario, Contraseña FROM Usuario WHERE Usuario = @Username AND Contraseña = @Password";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // Se añaden los parámetros a la consulta SQL
                        comando.Parameters.AddWithValue("@Username", username);
                        comando.Parameters.AddWithValue("@Password", password);

                        // Se ejecuta la consulta y se lee el resultado
                        using (SqlDataReader registro = comando.ExecuteReader())
                        {
                            if (registro.Read())
                            {
                                // Se encontró un usuario con las credenciales proporcionadas
                                ClsUsuario.Usuario = registro["Usuario"].ToString();
                                resultado = 1;
                            }
                            else
                            {
                                // No se encontró ningún usuario con las credenciales proporcionadas
                                resultado = -1;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones en caso de error en la conexión o consulta SQL
                Console.WriteLine("Error en la conexión o consulta SQL: " + ex.Message);
                resultado = -2; // Código de error personalizado
            }

            // Se devuelve el resultado de la validación del login
            return resultado;
        }
        #region metodos
        public void AgregarUsuario()
        {
        
        
        }
        public void EliminarUsuario() { }
        public void ConsultarUsuario() { }
        public void ObtenerDatos() { }
        #endregion
    }
}