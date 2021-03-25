<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarPost.aspx.cs" Inherits="DotNetSeguridad.Post.AgregarPost" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server">Titulo</asp:Label>
    <asp:TextBox runat="server" id="txtTitulo" CssClass="form-control"></asp:TextBox>
        <asp:Label runat="server">Resumen</asp:Label>

        <asp:TextBox runat="server" id="txtResumen" CssClass="form-control" Height="100"></asp:TextBox>
        <asp:Label runat="server">Cuerpo</asp:Label>

        <asp:TextBox runat="server" id="txtCuerpo" CssClass="form-control" Height="350"></asp:TextBox>

        <asp:Button runat="server" ID="btnAgregar" CssClass="btn btn-primary" OnClick="btnAgregar_Click" Text="Agregar"/>

</asp:Content>
