<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerCategorias.aspx.cs" Inherits="DotNetSeguridad.Categoria.VerCategorias" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Listview runat="server" ID="lstPosteos">
            <LayoutTemplate><%-- Equivalente a la "Masterpage" --%>
                        <ul class="list-group list-group-flush">                        
                            <asp:PlaceHolder runat="server" id="itemPlaceHolder"></asp:PlaceHolder>
                    </ul>
             </LayoutTemplate>

             <ItemTemplate><%--Equivalente a el WebForm con MasterPAge. Este se repite por cada elemento --%>
            
           
<li class="list-group-item">
    <div class="row">
        <div class="col">
            <%#Eval("Nombre") %>
        </div>
        <div class="col-md-auto">
            <a class="btn btn-success" href="/Categoria/EditarCategoria.aspx?id=<%#Eval("Id") %>" role="button">Editar</a>    
        </div>
        
        <div class="col col-lg-2">
            <a class="btn btn-danger" href="/Categoria/BorrarCategoria.aspx?id=<%#Eval("Id") %>" role="button">Borrar</a>    

        </div>
        
    </div>
</li>

            </ItemTemplate>
    </asp:Listview>
              <a class="btn btn-primary" href="/Categoria/AgregarCategoria.aspx?id=<%#Eval("Id") %>" role="button">Agregar</a>    


</asp:Content>