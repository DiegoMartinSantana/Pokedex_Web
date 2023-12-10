<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login2.aspx.cs" Inherits="Pokedex_Web.Login2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
             </div>
             <div class="form-floating mb-3">
                 <asp:Label  runat="server" CssClass="form-label">Password</asp:Label>

                 <asp:TextBox TextMode="Password" class="form-control" ID="txtpassword" runat="server" placeholder="Your Password" />
             </div>
             <div class="form-floating mb-3">
                 <asp:Button Text="Go to my Pokedex" runat="server" ID="btngopokedex" OnClick="btngopokedex_Click" CssClass="btn btn-dark" />
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
