﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarCategoria.aspx.cs" Inherits="DotNetSeguridad.Categoria.AgregarCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Nombre
    <asp:TextBox  CssClass="form-control" runat="server" id="txtNombre"></asp:TextBox>
    <asp:Button CssClass="btn btn-block btn-primary" runat="server" ID="btnGuardar" Text="Agregar" onClick="btnGuardar_Click" />
</asp:Content>