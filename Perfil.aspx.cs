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
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //POSIBLE VALIDAR POSTBACK ACA
                if (!IsPostBack)
                {
                    Trainee user = new Trainee();
                    user = (Trainee)Session["trainee"];
                    txtid.Text = user.Id.ToString();
                    txtemailuser.Text = user.email;

                    //LAS DEMAS NO SE SI ESTAN CARGADAS ASIQUE VALIDO QUE NO SEAN DISTINTAS DE NULOS ANTES

                    Txtname.Text = user.nombre;
                    Txtapellido.Text = user.apellido;
                    if (!string.IsNullOrEmpty(user.imgPerfil))
                    {
                        imgperfilgrande.ImageUrl = "~/Images/PerfilImgs/" + user.imgPerfil;
                    }
                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("Error2.aspx");
            }
        }


        protected void btnsave_Click(object sender, EventArgs e)
        {

            try
            {
                Trainee user = new Trainee();
                user = (Trainee)Session["trainee"];
                TraineeNegocio negocio = new TraineeNegocio();

                if (File1.PostedFile.FileName != "")
                {
                    string ruta = Server.MapPath("./Images/PerfilImgs/"); // extraigo del server la carpeta !
                    File1.PostedFile.SaveAs(ruta + "Perfil" + user.Id + ".jpg"); //aca extraigo de odnde subio ( el tipe file)
                    user.imgPerfil = "Perfil" + user.Id + ".jpg";
                    // y la guardo con save as en la ruta con el nombre especificado, que va a ir cambiando segun su id!
                    //AHORA LLAMO A METOD PARA INSERTAR TODOS LOS DATOS EN LA BASE DE DATOS
                }
                //aSGINO LOS DATO SPRIMERO

                user.nombre = Txtname.Text;
                user.apellido = Txtapellido.Text;

                // MANDO A METODO
                negocio.agregarDatos(user);


                //extraigo la de perfil que esta en mi Master
                Image img = (Image)Master.FindControl("imgAvatar");
                img.ImageUrl = "~/Images/PerfilImgs/" + user.imgPerfil;

                imgperfilgrande.ImageUrl = "~/Images/PerfilImgs/" + user.imgPerfil;


            }

            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("Error2.aspx");
            }



        }
    }
}