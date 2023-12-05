using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;
namespace Pokedex_Web
{
    public partial class Cardswithforeach : System.Web.UI.Page
    {
        public  List<Pokemon> listapoke { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] == null)
            {
                Session.Add("error", "Necesita loguearse para acceder.");
                Response.Redirect("Error.aspx", false);

            }

            PokemonNegocio negocio = new PokemonNegocio();
            listapoke = negocio.listwithstoredprocedure();
            // est valido queno sea postback! sino se refresca y se rompe,
            if (!IsPostBack)
            {
                rptrepetidor.DataSource = listapoke;
                rptrepetidor.DataBind();
            }
        }

        protected void btnargumment_Click(object sender, EventArgs e)
        {//aca capturo el command argument desde el sender!

            string Id = (((Button)sender).CommandArgument);
            // y ya con este id hago lo que quiera. enviarlo a otra pagina para mostrar o trabajar en el. o pasarselo a algo y asi..
        }
    }
}