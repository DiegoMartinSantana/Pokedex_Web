using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
namespace Pokedex_Web
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PokemonNegocio negocio = new PokemonNegocio();


                gdwpokemons.DataSource = negocio.listwithstoredprocedure();
                gdwpokemons.DataBind();
                List<Pokemon> lista = (List<Pokemon>)negocio.listwithstoredprocedure();
                Session.Add("listnofiltrada", lista);
            }
        }

        protected void gdwpokemons_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gdwpokemons.PageIndex = e.NewPageIndex;
            gdwpokemons.DataBind();
        }

        protected void gdwpokemons_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = gdwpokemons.SelectedDataKey.Value.ToString();
            Response.Redirect("FormPokemons.aspx?id=" + valor); //despues evaluo. si vino id es xque modifico, si no vino es xque doy de alta :D
        }

        protected void btnagregarpoke_Click(object sender, EventArgs e)
        {
            Response.Redirect("Formpokemons.aspx");
        }

        protected void txtfiltrorapido_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listfiltrada =(List<Pokemon> )Session["listnofiltrada"];
            listfiltrada = listfiltrada.FindAll(x => x.Nombre.ToUpper().Contains(txtfiltrorapido.Text.ToUpper())); // imrotante lo que fitre tmbien sea to upper
            //x = pokemon. busca en mayus (todo) si contiene algo del filtro textorapido!
            gdwpokemons.DataSource = listfiltrada;
            gdwpokemons.DataBind();

        }
    }
}