using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pokedex_Web
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            
            
                gdwpokemons.DataSource = negocio.listwithstoredprocedure();
                gdwpokemons.DataBind();
            
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
    }
}