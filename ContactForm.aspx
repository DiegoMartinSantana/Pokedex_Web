<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContactForm.aspx.cs" Inherits="Pokedex_Web.ContactForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">



        <div class="mb-3">
            <asp:Label Text="Ingrese su Email " runat="server" CssClass="form-label" />
            <asp:TextBox runat="server" TextMode="Email" CssClass="form-control" ID="txtemail" Style="max-width: 50%" />
        </div>
        <div class="mb-3">
            <asp:Label Text="Asunto " runat="server" CssClass="form-label" />
            <asp:TextBox runat="server" TextMode="SingleLine" CssClass="form-control" ID="txtasunto" Style="max-width: 50%" />

        </div>
        <div class="mb-3">
            <asp:Label Text="Mensaje" runat="server" CssClass="form-label" />
            <asp:TextBox runat="server" TextMode="MultiLine" CssClass="form-control" ID="txtmensaje" Style="max-width: 50%" />

        </div>

        <div class="mb-3">
            <asp:Button Text="Enviar" runat="server" CssClass="btn btn-primary" ID="btnenviaremail" OnClick="btnenviaremail_Click" />
        </div>
        <div class="mb-3">
            <asp:Label Text="Email enviado correctamente " runat="server" ID="lblenviado"  Visible="false" CssClass="form-label"/>
        </div>
    </div>

</asp:Content>
