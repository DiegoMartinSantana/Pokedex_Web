using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pokedex_Web
{
    public partial class Login2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btngopokedex_Click(object sender, EventArgs e)
        {
            Trainee user = new Trainee();
            TraineeNegocio negociotrainee = new TraineeNegocio();

            //guardo el contenido..
            try
            {

                user.email = txtemail.Text;
                user.pass = txtpassword.Text;
               

                bool activado = negociotrainee.loguear(user);

                if (activado)
                {
                    //lo guardo en session para manipularlo
                    Session.Add("trainee", user);
                    Response.Redirect("ListPokemons.aspx", false); // viaja a Menu

                }
                else
                {
                    Session.Add("error", "USUARIO O CONTRASEÑA INCORRECTOS");
                    Response.Redirect("Error2.aspx", false);
                }

            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString()); // despues lo guarda en una txt asique tiene que ser tipo string
                Response.Redirect("Error2.aspx", false);

            }
        }

    }
}