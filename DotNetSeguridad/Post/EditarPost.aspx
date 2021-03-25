<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarPost.aspx.cs" Inherits="DotNetSeguridad.Post.EditarPost" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server">Titulo</asp:Label>
    <asp:TextBox runat="server" id="txtTitulo" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        <asp:Label runat="server">Resumen</asp:Label>

        <asp:TextBox runat="server" id="txtResumen" CssClass="form-control" Height="100" TextMode="MultiLine"></asp:TextBox>
        <asp:Label runat="server">Cuerpo</asp:Label>

        <asp:TextBox runat="server" id="txtCuerpo" CssClass="form-control" Height="300" TextMode="MultiLine"></asp:TextBox>
    
        <asp:Button runat="server" ID="btnAgregar" CssClass="btn btn-primary" onClick="btnEditar_Click" Text="Editar"/>

        <asp:Button runat="server" ID="btnCancelar" CssClass="btn btn-danger" OnClick="btnCancelar_Click" Text="Cancelar" />

</asp:Content>
