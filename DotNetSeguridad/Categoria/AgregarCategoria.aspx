<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarCategoria.aspx.cs" Inherits="DotNetSeguridad.Categoria.AgregarCategoria" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br>
    Nombre
    <asp:TextBox  CssClass="form-control" runat="server" id="txtNombre"></asp:TextBox>
    <asp:Button CssClass="btn btn-block btn-primary" runat="server" ID="btnGuardar" Text="Agregar" onClick="btnGuardar_Click" />
</asp:Content>
