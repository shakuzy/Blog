<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ABMPost.aspx.cs" Inherits="DotNetSeguridad.Post.ABMPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
            <%#Eval("Titulo") %>
        </div>
        <div class="col-md-auto">
            <a class="btn btn-success" href="EditarPost.aspx?id=<%#Eval("Id") %>" role="button">Editar</a>    
        </div>
        
        <div class="col col-lg-2">
            <a class="btn btn-danger" href="BorrarPost.aspx?id=<%#Eval("Id") %>" role="button">Borrar</a>    

        </div>
        
    </div>
</li>

            </ItemTemplate>
    </asp:Listview>
              <a class="btn btn-primary" href="AgregarPost.aspx?id=<%#Eval("Id") %>" role="button">Agregar</a>    


</asp:Content>
