<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListPokemons.aspx.cs" Inherits="Pokedex_Web.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>There is all Pokemons we registered</h3>
    <p>Thanks for visit!. See you later!.</p>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="col">
                <div class="mb-3"> 
                <asp:Label Text="Filtro : " CssClass="form-label" runat="server" />
                <asp:TextBox runat="server" AutoPostBack="true" OnTextChanged="txtfiltrorapido_TextChanged" ID="txtfiltrorapido" CssClass="form-control" />
            </div>
                </div>
      


    <asp:GridView ID="gdwpokemons" runat="server" CssClass="table" AutoGenerateColumns="false" AllowPaging="true"
        OnPageIndexChanging="gdwpokemons_PageIndexChanging" PageSize="5" OnSelectedIndexChanged="gdwpokemons_SelectedIndexChanged"
        DataKeyNames="Id">

        <Columns>
            <asp:BoundField HeaderText="Numero " DataField="Numero" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Tipo" DataField="Tipo.Descripcion" />
            <asp:CheckBoxField HeaderText="Activo" DataField="Activo" />
            <asp:CommandField HeaderText="Acción" ShowSelectButton="true" SelectText="✍" />

        </Columns>

    </asp:GridView>
    <div>

        <asp:Button Text="Agregar" runat="server" CssClass="btn btn-dark" ID="btnagregarpoke" OnClick="btnagregarpoke_Click" />
    </div>
                </ContentTemplate>
</asp:UpdatePanel>
</asp:Content>
