<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Pokedex_Web.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <%--  aca recupero de la session el error y lo muestro! --%>

    <div class ="row">
        <h3> Ocurrio un Error </h3>
        <asp:Label Text="" ID="txterror" runat="server" CssClass="form-label" />
        
    </div>
</asp:Content>
