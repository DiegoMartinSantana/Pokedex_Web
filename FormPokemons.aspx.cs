using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pokedex_Web
{
    public partial class Form_Pokemons : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddltipo.Items.Add("Fuego");
                ddltipo.Items.Add("Agua");
                ddltipo.Items.Add("Planta");
                
                ddldebilidad.Items.Add("Planta");
                ddldebilidad.Items.Add("Fuego");
                ddldebilidad.Items.Add("Agua");




            }
        }
    }
}