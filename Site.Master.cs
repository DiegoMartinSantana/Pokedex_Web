using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;
using Seguridad;
namespace Pokedex_Web
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //aca valido que paginas muesta si esta logueado
            imgAvatar.ImageUrl = "https://simg.nicepng.com/png/small/202-2022264_usuario-annimo-usuario-annimo-user-icon-png-transparent.png";
           
            if (!(Page is Login2 || Page is Registro || Page is Error2)) // si la pagina no es login,  VALIDA
            {
                if (!(Seguridad.Seguridad.sesionActiva(Session["trainee"])))
                {
                    Response.Redirect("Login2.aspx", false);

                }
                
            }

        }
    }
}