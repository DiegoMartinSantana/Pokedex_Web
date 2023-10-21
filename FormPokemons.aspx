<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormPokemons.aspx.cs" Inherits="Pokedex_Web.Form_Pokemons" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%--<asp:ScriptManager runat="server" />     CON ESTO PUEDO USAR EL UPDATE PANEL,PERO YA ESTA EN MI MASTER PUESTO.--%>
    <style>
        .maxwidth {
            max-width: 648px;
        }
    </style>
    <div class="row " style="font-size: large">
        <div class="col-6 ">
            <div style="padding: 10px">

                <div class="mb-3">
                    <asp:Label Text="Id" runat="server" ID="lblid" CssClass="form-label " />
                    <asp:TextBox runat="server" CssClass="form-control  maxwidth" ID="txtid" />
                </div>
                <div class="mb-3">
                    <asp:Label Text="Numero" runat="server" CssClass="form-label" ID="lblnumero" />
                    <asp:TextBox runat="server" CssClass="form-control  maxwidth" ID="txtnumero" TextMode="Number" />
                </div>
                <div class="mb-3">
                    <asp:Label Text="Nombre" runat="server" CssClass="form-label" ID="lblnombre" />
                    <asp:TextBox runat="server" CssClass="form-control  maxwidth" ID="txtnombre" />
                </div>



                <div class="mb-3">
                    <asp:Label Text="Tipo " runat="server" CssClass="form-label  " ID="lbltipo" />
                    <asp:DropDownList ID="ddltipo" runat="server" CssClass="form-select  maxwidth"></asp:DropDownList>

                </div>

                <div class="mb-3">
                    <asp:Label Text="Debilidad" runat="server" CssClass="form-label" ID="lbldebilidad" />

                    <asp:DropDownList ID="ddldebilidad" runat="server" CssClass="form-select  maxwidth "></asp:DropDownList>

                </div>





            </div>
        </div>


        <div class="col-6 ">
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <div class="mb-3">
                        <asp:Label Text="Descripcion " runat="server" CssClass="form-label" ID="lbldescripcion" />

                        <asp:TextBox runat="server" CssClass="form-control  maxwidth" ID="txtdescripcion" TextMode="MultiLine" />
                    </div>
                    <div class="mb-3">
                        <asp:Label Text="Url de la imagen " runat="server" CssClass="form-label" ID="lblimagen" />
                        <asp:TextBox runat="server" CssClass="form-control  maxwidth" ID="txtimagen" AutoPostBack="true" OnTextChanged="txtimagen_TextChanged" />
                    </div>
                    <div>
                        <asp:Image ID="img1" runat="server" Style="width: 60%" AutoPostback="true" ImageUrl="https://elcomercio.pe/resizer/kxJIK2jjr2r6-H5EmhCZ13zf-5U=/580x330/smart/filters:format(jpeg):quality(90)/cloudfront-us-east-1.images.arcpublishing.com/elcomercio/66AM3SSB3ZGSJNU2TQAVJNHIWE.jpg" />

                    </div>

                </ContentTemplate>
            </asp:UpdatePanel>
            <div style="padding-block-start: 20px;">
                <asp:Button Text="Aceptar " runat="server" ID="btnaceptar" CssClass="btn btn-dark" OnClick="btnaceptar_Click" />
                <asp:Button Text="Cancelar " runat="server" ID="btncancelar" CssClass="btn btn-dark" OnClick="btncancelar_Click" />
                <asp:Button Text="Desactivar " runat="server" CssClass="btn btn-warning" ID="btndesactivar" OnClick="btndesactivar_Click" />
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <div style="padding-top: 10px; padding-block-end: 30px">
                            <asp:Button Text="Eliminar" runat="server" ID="btneliminar" CssClass="btn btn-danger" OnClick="btneliminar_Click" />

                            <%if (Eliminar) // si el chequed esta en ok significa que voy a eliminar entonces muestro l aocnfirmacion
                                {

                            %>

                            <asp:CheckBox runat="server" CssClass="form-check" ID="Chkeliminar" Style="display: inline" />
                            <asp:Label Text="Confirme Eliminacion " runat="server" CssClass="form-label" ID="lblconfirmareli" />
                            <asp:Button Text="Confirmar" ID="btnconfirmareli" runat="server" CssClass="btn btn-outline-danger" OnClick="btnconfirmareli_Click" />


                            <%} %>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>

            </div>
            </div>

        </div>
        <%-- div de la row--%>
</asp:Content>
