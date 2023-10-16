<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormPokemons.aspx.cs" Inherits="Pokedex_Web.Form_Pokemons" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .maxwidth{
            max-width:648px;
        }
    </style>
        <div class="row " style="font-size:large ">
            <div class="col-6 " ">
                <div style="padding: 10px">
               
                <div class="mb-3" >
                    <asp:Label Text="Id" runat="server" ID="lblid" CssClass="form-label " />
                    <asp:TextBox runat="server" CssClass="form-control  maxwidth" ID="txtid" />
                </div>

                <div class="mb-3">
                    <asp:Label Text="Nombre" runat="server" CssClass="form-label" ID="lblnombre" />
                    <asp:TextBox runat="server" CssClass="form-control  maxwidth" ID="txtnombre" />
                </div>

                <div class="mb-3">
                    <asp:Label Text="Descripcion " runat="server" CssClass="form-label" ID="lbldescripcion" />
                    <asp:TextBox runat="server" CssClass="form-control  maxwidth" ID="txtdescripcion" TextMode="MultiLine" />
                </div>

                <div  class="mb-3">
                    <asp:Label Text="Tipo " runat="server" CssClass="form-label  " ID="lbltipo" />
                    <asp:DropDownList ID="ddltipo" runat="server" CssClass="form-select  maxwidth"></asp:DropDownList>

                </div>

                <div  class="mb-3" >
                    <asp:Label Text="Debilidad" runat="server" CssClass="form-label" ID="lbldebilidad" />

                    <asp:DropDownList ID="ddldebilidad" runat="server" CssClass="form-select  maxwidth "></asp:DropDownList>

                </div>

                <div style="padding-block-start:20px;">
                    <asp:Button Text="Aceptar "  runat="server" ID="btnaceptar" CssClass="btn btn-dark" />
                    <asp:Button Text="Cancelar "  runat="server" ID="btncancelar" CssClass="btn btn-dark" />

                </div>



            </div>
                 </div>

        </div>

</asp:Content>
