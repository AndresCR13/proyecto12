using proyecto12.CapaLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyecto12.CapaVista
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BIngresar_Click(object sender, EventArgs e)
        {

            if (ClsusuarioDA.ValidarLogin(TUsuario.Text, TClave.Text)>0)
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}