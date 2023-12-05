using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pokedex_Web
{
    public partial class ContactForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        protected void btnenviaremail_Click(object sender, EventArgs e)
        {
            EmailService service = new EmailService();
            service.armarCorreo(txtemail.Text, txtasunto.Text, txtmensaje.Text);
            try
            {
                service.enviarCorreo();
                lblenviado.Visible = true;
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx");
            }

        }
    }
}