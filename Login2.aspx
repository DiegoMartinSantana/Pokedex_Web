<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login2.aspx.cs" Inherits="Pokedex_Web.Login2" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <script>
       function vacio() {

           const txtpass = document.getElementById("txtpassword");

           if (txtpass.value == "") {
               alert("oass vacia");
               txtpass.classList.add("is-invalid");
               return false;

           }
           txtpass.classList.remove("is-invalid");
           txtpass.classList.add("is-valid");

           return true;
       }
   </script>
    <main>
        
     <%if (Session["trainee"] == null)
         {
     %>
     <div class="row">
         <section class="col-md-4" aria-labelledby="gettingStartedTitle">
             <p>
                 Welcome to your pokedex.
                 Please Log-in.
             </p>

         </section>
     </div>

     <div class="row">
         <section class="col-md-4">
             <div class="form-floating mb-3">
                 <asp:Label runat="server" CssClass="form-label">Enter your Email </asp:Label>

                 <asp:TextBox class="form-control" ID="txtemail" placeholder="Your Username" runat="server" />
           <!-- 
               Ejemplos de valdiaciones con asp validators
               //importante.  O DESACTIVO LA CARGA CENTRALIZADA EN MI CONFIG O AGREGO EL SCRIPT EN MI ASAX
                 --<asp:RequiredFieldValidator CssClass="validacion" ErrorMessage="El nombre es requerido" ControlToValidate="txtNombre" runat="server" />--%>
                <%--<asp:RangeValidator ErrorMessage="Fuera de rango.." ControlToValidate="txtApellido" Type="Integer" MinimumValue="1" MaximumValue="20" runat="server" />--%>
                <%--<asp:RegularExpressionValidator ErrorMessage="Formato email por favor" ControlToValidate="txtApellido" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" runat="server" />--%>

                <%--<asp:RegularExpressionValidator ErrorMessage="Formato incorrecto..." ControlToValidate="txtApellido" ValidationExpression="^[0-9]+$" runat="server"/>--%>

               CODE BEHIND : VALIDAR QUE NO ENTRE Y QUE HAGA EL RETURN CORRECTO
               
               EN MI LLAMADO A ACCION ( LOGIN ) ,PARA TODAS LAS VALIDATORS DE CUALQUIER TIPO
                Page.Validate();
                if (!Page.IsValid) SI LA PAGINA NO ES VALIDA RETORNA!
                     return;    
               
               
               -->
                 </div>
             <div class="form-floating mb-3">
                 <asp:Label   runat="server" CssClass="form-label">Password</asp:Label>

                 <asp:TextBox TextMode="Password" ClientIDMode="Static"  class="form-control" ID="txtpassword" runat="server" placeholder="Your Password"  />
             </div>
             <div class="form-floating mb-3">
                 <asp:Button Text="Go to my Pokedex" runat="server" ID="btngopokedex" OnClick="btngopokedex_Click" CssClass="btn btn-dark" OnClientClick="return vacio()" />
             </div>
         </section>

     </div>
     <%}
         else
         { %>
             <h4> You are on.</h4>

     <%    } %>
 </main>
</asp:Content>
