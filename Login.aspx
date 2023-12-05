<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Pokedex_Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <%if (Session["User"] == null)
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
                    <asp:TextBox class="form-control" ID="txtusername" placeholder="Your Username" runat="server" />
                    <asp:Label runat="server" for="txtusername" CssClass="form-label">Enter your Username </asp:Label>
                </div>
                <div class="form-floating mb-3">
                    <asp:TextBox TextMode="Password" class="form-control" ID="txtpassword" runat="server" placeholder="Your Password" />
                    <asp:Label for="txtpassword" runat="server" CssClass="form-label">Password</asp:Label>
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
