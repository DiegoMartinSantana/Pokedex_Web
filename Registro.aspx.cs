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
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncancelar_Click(object sender, EventArgs e)
        {

            Response.Redirect("Login.aspx", false);


        }

        protected void btnregistrarse_Click(object sender, EventArgs e)
        {

            try
            {

                Trainee pepe = new Trainee();
                TraineeNegocio traineeNegocio = new TraineeNegocio();

                EmailService emailservice = new EmailService();

                pepe.email = txtemailreg.Text;
                pepe.pass = txtpasswordreg.Text;
                

                pepe.Id = traineeNegocio.insertar(pepe); // me devuelve  el id!
                emailservice.armarCorreo(pepe.email, "Welcome", "Congratulations. You are a Pokemon Trainee! ");
                emailservice.enviarCorreo();

                Session.Add("trainee", pepe);
                Response.Redirect("ListPokemons.aspx", false);



            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
                Response.Redirect("Erorr.aspx", false);
            }


        }
    }
}