<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EXP.UI.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%--    <link href="Content/Site.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />--%>
        <h1>Exemple MakeSens</h1>
        <p class="lead">Simple exemple d&#39;implantation d&#39;une validation de MakeSens.</p>
        <p><a href="http://www.gbsens.ca" class="btn btn-primary btn-lg">Consulter notre site »</a></p>
        
        
        
        <div id="MKSMSG"  class="alert alert-<%= this._MessageSeverity %>">
            <a href="#" class="close" data-dismiss="alert">&times;</a>
            <strong><%=this._MessageTitre %></strong> <%= this._MessageDescription %>
        </div>
            
        <div >
                <asp:Label  ID="lblNom" runat="server" Text="Label"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txtNom" runat="server"></asp:TextBox>
        </div>
        <div>
                <asp:Label   ID="lblPrenom" runat="server" Text="Label"></asp:Label>
                <asp:TextBox CssClass="form-control"  ID="txtPrenom" runat="server"></asp:TextBox>
        </div>
                <asp:Label   ID="lblTelephone" runat="server" Text="Label"></asp:Label>
                <asp:TextBox CssClass="form-control"  ID="txtTelephone" runat="server"></asp:TextBox>
        <div>

                <br />

                <asp:Button CssClass="btn btn-primary btn-lg" ID="btnSauvegarder" runat="server" Text="Button" OnClick="btnSauvegarder_Click" />
                <br />
            

                <asp:Button CssClass="btn btn-primary btn-lg" ID="btnAbout" runat="server" Text="Button" OnClick="btnAbout_Click" />
               
        </div>

</asp:Content>
