<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DotNetSeguridad._Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Estos son los ultimos posteos</h3>
    <asp:Label runat="server" ID="lbllbl"></asp:Label>
    <asp:Listview runat="server" ID="lstPosteos">
            <LayoutTemplate><%-- Equivalente a la "Masterpage" --%>
                    <div class="card-columns">
                        <asp:PlaceHolder runat="server" id="itemPlaceHolder"></asp:PlaceHolder>
                    </div>
             </LayoutTemplate>

             <ItemTemplate><%--Equivalente a el WebForm con MasterPAge. Este se repite por cada elemento --%>
            
  
            <div class="card">
                <div class="card-body">
                  <h5 class="card-title">
                      <a href="Post/verPost.aspx?id=<%#Eval("Id") %>"> <%#Eval("Titulo") %></a>
                    </h5>
                  <p class="card-text"><%#Eval("Resumen") %></p>
                 </div>
            </div>
            </ItemTemplate>
    </asp:Listview>
</asp:Content>


