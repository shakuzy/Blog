<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarCategoria.aspx.cs" Inherits="DotNetSeguridad.Categoria.EditarCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label runat="server" ID="lblNombre">Nombre</asp:Label>
<asp:TextBox CssClass="form-control" runat="server" id="txtNombre" ></asp:TextBox>
    <asp:Button CssClass="btn btn-block btn-primary" runat="server" ID="btnGuardar" Text="Guardar" OnClick="btnGuardar_Click" />
            <asp:Button runat="server" ID="btnCancelar" CssClass="btn btn-block btn-danger" onClick="btnCancelar_Click" Text="Cancelar" />

</asp:Content>
