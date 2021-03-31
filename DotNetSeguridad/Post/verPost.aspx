<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="verPost.aspx.cs" Inherits="DotNetSeguridad.Post.verPost" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1><asp:Label runat="server" ID="lblTitulo"></asp:Label></h1>
        <asp:Label runat="server">                                           </asp:Label><br>

    <asp:Label runat="server">                                               </asp:Label><br>
    <h4><asp:Label runat="server" ID="lblResumen"></asp:Label></h4>
    <asp:Label runat="server">                                               </asp:Label><br>
    <asp:Label runat="server">                                               </asp:Label><br>


    <asp:Label runat="server" ID="lblCuerpo"></asp:Label>
    
    
        
<asp:Panel runat="server" id="pnlAdmin" Visible="false">

    <asp:ListView runat="server" ID="lstComentarios">
        <LayoutTemplate>
                               <h1>Comentarios</h1>
                    <asp:Button runat="server" class="btn btn-danger" Visible="true" id="btnBorrarTodoslosComentarios" Text="Borrar Todos" OnClick="btnBorrarTodoslosComentarios_Click" />

            <div class="card border-success mb-6" >
            <asp:PlaceHolder runat ="server" Id="itemPlaceHolder"></asp:PlaceHolder>
     </div>


        </LayoutTemplate>
        <ItemTemplate>
          <hr> <hr>
              <div class="card-header bg-transparent border-success"><h5>De: <%#Eval("Autor") %></h5></div>
  <div class="card-body text-success">
    <h5 class="card-title"><%#Eval("Comentario1") %></h5>
  </div>
      
  <div class="card-footer bg-transparent border-success">
      <a class="btn btn-danger" href="/Comentario/BorrarComentario.aspx?id=<%#Eval("Id") %>&idPost=<%#Eval("IdPost") %>">
          Borrar Comentario

      </a>
      

       
        
</div>
        </ItemTemplate>
    </asp:ListView>
</asp:Panel>


    <asp:Panel runat="server" id="pnlUser" Visible="false">

        <asp:ListView runat="server" ID="ListView1">
        <LayoutTemplate>
                               <h1>Comentarios</h1>

            <div class="card border-success mb-6" style="max-width: 18rem;">
            <asp:PlaceHolder runat ="server" Id="itemPlaceHolder"></asp:PlaceHolder>
     </div>


        </LayoutTemplate>
        <ItemTemplate>
          
              <div class="card-header bg-transparent border-success"><asp:Label runat="server" id="lblComentarioAutor">Comentario de: <%#Eval("Autor") %></asp:Label></div>
  <div class="card-body text-success">
    <h5 class="card-title"><%#Eval("Comentario1") %></h5>
  </div>
      
  
        </ItemTemplate>
    </asp:ListView>
    </asp:Panel>
    
    <br />
    <div class ="container">
    <h1>Agregar un nuevo comentario</h1>
    <asp:Label runat="server" id="lblAutor">Autor</asp:Label>
    <asp:TextBox CssClass="form-control" runat="server" visible="true" id="txtAutor"></asp:TextBox><br>
    <asp:Label runat="server">Comentario</asp:Label>
    <asp:TextBox CssClass="form-control" runat="server" ID="txtComentario"></asp:TextBox>

    <asp:Button  runat="server" ID="btn_AgregarComentario" CssClass="btn btn-primary" Text="Agregar Comentario" OnClick="btn_AgregarComentario_Click" />
        </div>
</asp:Content>