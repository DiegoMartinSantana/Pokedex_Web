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
    public partial class Form_Pokemons : System.Web.UI.Page
    {
        public bool Eliminar { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            txtid.Enabled = false; //id es automatico. no tiene que ser cargable.
            Eliminar = false;
            //LOS DESPEGABLES LOS CARGAMOS CON EL NEGOCIO NO ESTATICOS.,ASI DESPUES SI AGREGO UNO MAS SE AGREGA AUTOMATICO.
            try
            {
                if (!IsPostBack)
                {

                    ElementoNegocio elenegocio = new ElementoNegocio();

                    List<Elemento> listaelementos = elenegocio.listar(); //guardo en la lista todos los elementos.

                    ddldebilidad.DataSource = listaelementos; //se los paso al desplegable.
                    ddldebilidad.DataValueField = "Id";     //configuro el dato a manejar y el dato a mostrar;
                    ddldebilidad.DataTextField = "Descripcion"; // esto muestra
                    ddldebilidad.DataBind(); //bindeo el desplegable

                    ddltipo.DataSource = listaelementos;
                    ddltipo.DataValueField = "Id";
                    ddltipo.DataTextField = "Descripcion";
                    ddltipo.DataBind();

                    Eliminar = false;

                }
            }
            catch (Exception ex) //la mando a la sessiion para despues trabajarla en otro form o algo..
            {
                Session.Add("error", ex);
                throw;
            }
            //si el id es distinto de nulo /  guardalo                            / sino vacio
            string idmodificar = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";
            if (idmodificar != null && !IsPostBack)
            {
                PokemonNegocio negocio = new PokemonNegocio();
                /* List<Pokemon> lista = negocio.listar(idmodificar); me devuelve un solo onjeto xque setee la consulta.
                 Pokemon modificar = lista[0];
                */
                Pokemon modificar = (negocio.listar(idmodificar))[0]; // DEVUELVE UNA LIUSTA DE POKEMONS ASIQUE EXTRAIGO SU UNICO ELEMENTO
                //precargo los despeglabless.
                txtnombre.Text = modificar.Nombre;
                txtnumero.Text = modificar.Numero.ToString();
                txtdescripcion.Text = modificar.Descripcion.ToString();
                txtimagen.Text = modificar.UrlImagen;
                ddldebilidad.Text = modificar.Debilidad.Id.ToString();
                ddltipo.Text = modificar.Tipo.Id.ToString();
                txtid.Text = modificar.Id.ToString();

                //si vino un id es porque vo a hacer la reactivacion

                if (!modificar.Activo)
                {
                    btndesactivar.Text = "Activar";

                }

                //envio el objeto a ala session
                Session.Add("pokemodificar", modificar);
            }


        }

        protected void txtimagen_TextChanged(object sender, EventArgs e)
        {
            img1.ImageUrl = txtimagen.Text;

        }

        protected void btnaceptar_Click(object sender, EventArgs e)
        {
            try
            {
                //si acepta significa que carga un nuevo pokemon.Entonces obtenemos los valores.
                Pokemon nuevo = new Pokemon();
                nuevo.Nombre = txtnombre.Text;
                nuevo.Numero = int.Parse(txtnumero.Text);
                nuevo.Tipo = new Elemento(); //CARGO LOS ELEMENTOS. LE DIGO QUE ES NUEVO TIPO, DE ELEMENTO(QUE ES UN ELEMENTO)
                                             //ELEMENOS TIENEN ID Y DESCRIPCION. CARGO EL ID,EL OTRO ES AUTOMATICO(?)


                nuevo.Tipo.Id = int.Parse(ddltipo.SelectedValue);
                nuevo.Debilidad = new Elemento();
                nuevo.Debilidad.Id = int.Parse(ddldebilidad.SelectedValue);
                nuevo.UrlImagen = txtimagen.Text;
                nuevo.Descripcion = txtdescripcion.Text;

                PokemonNegocio negocio = new PokemonNegocio();
                //aca si el id es disinto de null modifica.

                if (Request.QueryString["id"] != null)
                {
                    nuevo.Id = int.Parse(Request.QueryString["id"]);
                    negocio.modificarwithsp(nuevo); //aca llamo a metodo para listarlo con un stored procedure y no la consulta suelta.
                }
                else
                {
                    negocio.agregarwithsp(nuevo);
                    //todo esto lo mando a la bolsa con un sp! arriba je.
                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }


            Response.Redirect("ListPokemons.aspx");
        }

        protected void btncancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListPokemons.aspx");
        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            Eliminar = true;
        }

        protected void btnconfirmareli_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (Chkeliminar.Checked)
                {
                    PokemonNegocio negocio = new PokemonNegocio();
                    int id = int.Parse(txtid.Text); // le paso el contenido de la caja de texto.
                    negocio.eliminarwithsp(id);
                    Response.Redirect("ListPokemons.aspx");

                }


            }
            catch (Exception ex)
            {
                Session.Add("error", ex);

                throw;
            }
        }

        protected void btndesactivar_Click(object sender, EventArgs e)
        {
            //recupero el objeto desde la session.
            Pokemon poke =(Pokemon) Session["pokemodificar"];

            PokemonNegocio negocio = new PokemonNegocio();
            negocio.eliminarLogico(int.Parse(txtid.Text),!poke.Activo); // si esta activo quiero desactivarlo , y viceversa.
            Response.Redirect("ListPokemons.aspx");


        }
    }
}