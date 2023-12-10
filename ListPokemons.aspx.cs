using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Pokedex_Web
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                    //va entre otro parentesis porque quiero extraer algo
            

          if (!IsPostBack)
            {

                PokemonNegocio negocio = new PokemonNegocio();
                gdwpokemons.DataSource = negocio.listwithstoredprocedure();
                List<Pokemon> lista = (List<Pokemon>)negocio.listwithstoredprocedure();
                Session.Add("listnofiltrada", lista);
                gdwpokemons.DataBind();

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
            List<Pokemon> listfiltrada = (List<Pokemon>)Session["listnofiltrada"];
            listfiltrada = listfiltrada.FindAll(x => x.Nombre.ToUpper().Contains(txtfiltrorapido.Text.ToUpper())); // imrotante lo que fitre tmbien sea to upper
            //x = pokemon. busca en mayus (todo) si contiene algo del filtro textorapido!
            gdwpokemons.DataSource = listfiltrada;
            gdwpokemons.DataBind();

        }
        protected void chkavanzado_CheckedChanged(object sender, EventArgs e)
        {
            txtfiltrorapido.Enabled = !chkavanzado.Checked; //si esta checked lo ocultaa
        }
        protected void ddlcampo_SelectedIndexChanged(object sender, EventArgs e)
        {                //limpio los items

            ddlcriterio.Items.Clear();

            if (ddlcampo.SelectedItem.ToString() == "Número")
            {

                ddlcriterio.Items.Add("Mayor a");
                ddlcriterio.Items.Add("Menor a");
                ddlcriterio.Items.Add("Igual a");


            }
            else
            {
                ddlcriterio.Items.Add("Empieza con");
                ddlcriterio.Items.Add("Contiene");
                ddlcriterio.Items.Add("Termina con");
            }
        }

        protected void btnbuscaravanzado_Click(object sender, EventArgs e)
        {
            try
            {
                PokemonNegocio negocio = new PokemonNegocio();
                gdwpokemons.DataSource = negocio.filtrar(ddlcampo.SelectedItem.ToString(), ddlcriterio.SelectedItem.ToString(), txtfiltro.Text, ddlestado.SelectedItem.ToString());

                gdwpokemons.DataBind();
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                Response.Redirect("Error2.aspx", false);
            }


        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Session.Add("Trainee", null);
            Response.Redirect("Login2.aspx");

        }
    }
}