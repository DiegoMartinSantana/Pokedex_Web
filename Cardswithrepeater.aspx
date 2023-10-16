<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cardswithrepeater.aspx.cs" Inherits="Pokedex_Web.Cardswithforeach" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row row-cols-1 row-cols-md-3 g-4">
    <asp:Repeater runat="server" ID="rptrepetidor">
        <ItemTemplate>
            <div class="card" style="width: 18rem;">
                <img src="<%#Eval("UrlImagen") %>" class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title"><%#Eval("Nombre") %></h5>
                    <p class="card-text"><%#Eval("Descripcion") %></p>
                    <a href="#" class="btn btn-primary">Go somewhere</a>
                    <asp:Button Text="Capture Id " runat="server" ID="btnargumment"  OnClick="btnargumment_Click" CommandArgument='<%#Eval("Id") %>' CommandName="IdPoke" CssClass="btn btn-primary"/> <%-- aca le paso el commando aggument para capturar el id o lo que sea--%>
               
                    </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
        </div>
  
</asp:Content>
