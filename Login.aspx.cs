using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;
namespace Pokedex_Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btngopokedex_Click(object sender, EventArgs e)
        {
            Users user;
            UsuarioNegocio negociouser = new UsuarioNegocio();

            //guardo el contenido..
            try
            {

                user = new Users(txtusername.Text, txtpassword.Text, false); //lo pisa la Bd si es distinto

                bool activado = negociouser.loguear(user);

                if (activado)
                {
                    //lo guardo en session para manipularlo
                    Session.Add("User", user);
                    Response.Redirect("ListPokemons.aspx", false); // viaja a Menu

                }
                else
                {
                    Session.Add("error", "USUARIO O CONTRASEÑA INCORRECTOS");
                    Response.Redirect("Error.aspx", false);
                }

            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString()); // despues lo guarda en una txt asique tiene que ser tipo string
                Response.Redirect("Error.aspx", false);

            }
        }



    }
}