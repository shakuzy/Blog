<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarComentario.aspx.cs" Inherits="DotNetSeguridad.Comentario.EditarComentario" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1><asp:Label runat ="server">Editar Comentario</asp:Label></h1>
    <asp:Label runat ="server">Autor</asp:Label>
    <asp:TextBox runat="server" CssClass="form-control" id="txtAutor"></asp:TextBox>
    <asp:Label runat ="server">Comentario</asp:Label>
    <asp:TextBox CssClass="form-control" runat="server" id="txtComentario"></asp:TextBox>
    <asp:Button runat="server" ID="btnEditarComentario" CssClass="btn btn-success" Text="Editar Comentario" OnClick="btnEditarComentario_Click"/>
</asp:Content>
