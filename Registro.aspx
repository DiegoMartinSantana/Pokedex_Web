<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Pokedex_Web.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col">
        <div class="mb-3">
            <label class="form-label">Email address</label>
            <asp:TextBox runat="server" CssClass="form form-control" ID="txtemailreg" placeholder="name@example.com" TextMode="Email" Style=" max-width:50% " />
        </div>
        <div class="mb-3">
            <label  class="form-label" >Password</label>
            <asp:TextBox runat="server" class="form-control" ID="txtpasswordreg" TextMode="Password" Style=" max-width:50% " />
        </div>

        <div>
            <asp:Button Text="Crear " runat="server" CssClass="btn btn-secondary" ID="btnregistrarse" OnClick="btnregistrarse_Click"  />
            <asp:Button runat="server" CssClass="btn btn-close " ID="btncancelar" OnClick="btncancelar_Click" Style="padding-left:40px " />

        </div>
    
    
    </div>


</asp:Content>
