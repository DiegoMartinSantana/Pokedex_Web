<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListPokemons.aspx.cs" Inherits="Pokedex_Web.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-2">
            <div class="mb-3">
                <!-- en una funcion esto.. --> 
                <%if ( Session["trainee"]!= null &&   ((dominio.Trainee)Session["trainee"]).admin == true) // si es admin
                    {
                        txtshowuser.Text = " Welcome User type Admin. ";
                    }
                    else
                    {
                        txtshowuser.Text = " Welcome User. ";
                        
                    } %>
                <asp:Label ID="txtshowuser" runat="server" />

            </div>
        </div>
        
    </div>
    <h2>This is your list of Pokemons </h2>

    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <asp:Label Text="Filtrar" runat="server" />
                <asp:TextBox runat="server" ID="txtfiltrorapido" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtfiltrorapido_TextChanged" />
            </div>
        </div>
        <div class="col-6" style="display: flex; flex-direction: column; justify-content: flex-end;">
            <div class="mb-3">
                <asp:CheckBox Text="Filtro Avanzado"
                    CssClass="" ID="chkavanzado" runat="server"
                    AutoPostBack="true"
                    OnCheckedChanged="chkavanzado_CheckedChanged" />
            </div>
        </div>

        <%if (chkavanzado.Checked)
            { %>
        <div class="row">
            <div class="col-3">
                <div class="mb-3">
                    <asp:Label Text="Campo" ID="lblCampo" runat="server" />
                    <asp:DropDownList runat="server" AutoPostBack="true" CssClass="form-control" ID="ddlcampo" OnSelectedIndexChanged="ddlcampo_SelectedIndexChanged">
                        <asp:ListItem Text="Nombre" />
                        <asp:ListItem Text="Tipo" />
                        <asp:ListItem Text="Número" />
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-3">
                <div class="mb-3">
                    <asp:Label Text="Criterio" runat="server" />
                    <asp:DropDownList runat="server" ID="ddlcriterio" CssClass="form-control"></asp:DropDownList>
                </div>
            </div>
            <div class="col-3">
                <div class="mb-3">
                    <asp:Label Text="Filtro" runat="server" />
                    <asp:TextBox runat="server" ID="txtfiltro" CssClass="form-control" />
                </div>
            </div>
            <div class="col-3">
                <div class="mb-3">
                    <asp:Label Text="Estado" runat="server" />
                    <asp:DropDownList runat="server" ID="ddlestado" CssClass="form-control">
                        <asp:ListItem Text="Todos" />
                        <asp:ListItem Text="Activo" />
                        <asp:ListItem Text="Inactivo" />
                    </asp:DropDownList>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-3">
                <div class="mb-3">
                    <asp:Button Text="Buscar" runat="server" CssClass="btn btn-primary" ID="btnbuscaravanzado" OnClick="btnbuscaravanzado_Click" />
                </div>
            </div>
        </div>
        <%} %>
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
</asp:Content>
