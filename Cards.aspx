<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cards.aspx.cs" Inherits="Pokedex_Web.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row row-cols-1 row-cols-md-3 g-4 ">
    <%   
        foreach (dominio.Pokemon poke in List) // usa del dominio un  pokemon (le digo el tipo de variable que es).
        {%>
             <div class="card" style="width: 18rem;"> 
        <img src="<%: poke.UrlImagen %>" class="card-img-top" alt="...">   
        <div class="card-body">
            <h5 class="card-title"> <%: poke.Nombre %>  </h5>
            <p class="card-text"> <%: poke.Descripcion %>  </p>
            <a href="#" class="btn btn-primary">Go somewhere</a> 
              </div>
             </div>
    <%} //en href podria pasarle el id para que lo mande a otra pagina ! :D %>
        </div>
</asp:Content>
