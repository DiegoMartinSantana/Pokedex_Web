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
    public partial class Contact : Page
    {
        public List<Pokemon> List { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            List = negocio.listwithstoredprocedure(); // AHORA YAPUEDO USAR LA LISTA EN MI FRONT.
        }
    }
}