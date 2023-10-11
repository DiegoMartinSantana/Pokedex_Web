<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListPokemons.aspx.cs" Inherits="Pokedex_Web.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>There is all Pokemons we registered</h3>
        <p>Thanks for visit!. See you later!.</p>


    </main>
    <asp:GridView ID="gdwpokemons" runat="server" CssClass="table"></asp:GridView>

</asp:Content>
