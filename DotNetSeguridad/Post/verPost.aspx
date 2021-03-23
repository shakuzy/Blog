<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="verPost.aspx.cs" Inherits="DotNetSeguridad.Post.verPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><asp:Label runat="server" ID="lblTitulo"></asp:Label></h1>
        <asp:Label runat="server">                                           </asp:Label><br>

    <asp:Label runat="server">                                               </asp:Label><br>
    <h4><asp:Label runat="server" ID="lblResumen"></asp:Label></h4>
    <asp:Label runat="server">                                               </asp:Label><br>
    <asp:Label runat="server">                                               </asp:Label><br>

    <asp:Label runat="server" ID="lblCuerpo"></asp:Label>

    <hr>
    <asp:ListView runat="server" ID="lstComentarios">
        <LayoutTemplate>
            <div class="card bg-light mb-3" >
  <div class="card-header">Comentarios</div>
                               <asp:Button runat="server" class="btn btn-danger" id="btnBorrarTodoslosComentarios" Text="Borrar Todos" OnClick="btnBorrarTodoslosComentarios_Click"/>

  <div class="card-body">
            <asp:PlaceHolder runat ="server" Id="itemPlaceHolder"></asp:PlaceHolder>
      </div>
</div>
        </LayoutTemplate>
        <ItemTemplate>
          <hr>
            <h5 class="card-title">Comentario de: <%#Eval("Autor") %></h5>
                 <p class="card-text"><%#Eval("Comentario1") %></p>
              <a class="btn btn-danger" href="/Comentario/BorrarComentario.aspx?id=<%#Eval("Id") %>&idPost=<%#Eval("IdPost") %>"> Borrar Comentario</a>
               <a class="btn btn-success" href="/Comentario/EditarComentario.aspx?id=<%#Eval("Id") %>&idPost=<%#Eval("IdPost") %>"> Editar Comentario</a>

        </ItemTemplate>
    </asp:ListView>

    <h1>Agregar un nuevo comentario</h1>
    <asp:Label runat="server">Autor</asp:Label>
    <asp:TextBox CssClass="form-control" runat="server" ID="txtAutor"></asp:TextBox>
    <asp:Label runat="server">Comentario</asp:Label>
    <asp:TextBox CssClass="form-control" runat="server" ID="txtComentario"></asp:TextBox>

    <asp:Button  runat="server" ID="btn_AgregarComentario" CssClass="btn btn-primary" Text="Agregar Comentario" OnClick="btn_AgregarComentario_Click" />

</asp:Content>