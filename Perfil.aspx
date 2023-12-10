<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="Pokedex_Web.Perfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-6">
            <div class="mb-3">

                <asp:Label ID="Lblid" runat="server" Text="Id :" CssClass="form-label "></asp:Label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtid" ReadOnly="true" Style="max-width: 80%" />
            </div>
            <div class="mb-3">

                <asp:Label ID="Lblemailuser" runat="server" Text="Email :" CssClass="form-label"></asp:Label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtemailuser" ReadOnly="true" Style="max-width: 80%" />
            </div>
            <div class="mb-3">
                <asp:Label ID="lblname" runat="server" Text="Name :" CssClass="form-label"></asp:Label>
                <asp:TextBox runat="server" CssClass="form-control" ID="Txtname" Style="max-width: 80%" />
            </div>
            <div class="mb-3">
                <asp:Label ID="lblapelllido" runat="server" Text="Surname :" CssClass="form-label"></asp:Label>
                <asp:TextBox runat="server" CssClass="form-control" ID="Txtapellido" Style="max-width: 80%" />
            </div>

            <div class="mb-3">
                <asp:Label ID="lblnacimiento" runat="server" Text="Date Born :" CssClass="form-label"></asp:Label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtBorn" TextMode="Date" Style="max-width: 50%" />
            </div>


        </div>

        <div class="col-md-6">
            <div class="mb-3">
                <asp:Label ID="lblurlimg" runat="server" Text="Url Image :" CssClass="form-label"></asp:Label>

            </div>
            <div class="mb-3">
                <input type="file" id="File1" runat="server" cssclass="form-control" />
            </div>

            <div class="mb-3">
                <asp:Image  runat="server" ID="imgperfilgrande" CssClass="img-fluid mb-3" Style="height: 300PX;"  />

            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6">
            <asp:Button Text="Save Data" ID="btnsave" OnClick="btnsave_Click" CssClass="btn btn-primary" runat="server" />
        </div>
    </div>

</asp:Content>
