<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ManageNotebooks.aspx.cs" Inherits="MyNotebooks.ManageNotebooks" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div style="border-radius: 2px;" id="about" runat="server" class="jumbotron">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2>Тетрадки</h2>
                    <hr class="star-light">
                    <input type="text" id="myInput" onkeyup="filter()" placeholder="Филтриране по име..">
                </div>
            </div>
        </div>
    </div>
    <div class="jumbotron">
        <div class="row">
            <%if (this.GetNotebooks.Count <= 0)
                { %>
            <h3 style="color: red" class="text-center">За съжаление, до този момент нямате достъп до тетрадки!</h3>
            <%} %>
            <% for (int i = 0; i < this.GetNotebooks.Count; i++)
                { %>
                    <a href="/CheckNotebook?studentName=<%= this.GetNotebooks.ElementAt(i).StudentName%>&Subject=<%=this.Titles.FirstOrDefault(n => n.Key == this.GetNotebooks.ElementAt(i).Subject).Value  %>&Bg=<%= this.GetNotebooks.ElementAt(i).Subject %>" class="thumbnail" title="<%=this.GetNotebooks.ElementAt(i).StudentName %>">
                        <img style="width: 200px; height: 200px;" class="img-circle img-responsive profile-image" src="<%=Request.ApplicationPath + "Uploaded_Files/" + this.GetNotebooks.ElementAt(i).StudentName + ".png"  %>"/>
                        <div class="caption">
                            <p class="text-center"><%=this.GetNotebooks.ElementAt(i).Subject %></p>
                            <p class="text-center"><%=this.GetNotebooks.ElementAt(i).StudentName %></p>
                        </div>
                    </a>
            <%} %>
        </div>
    </div>
    <%= System.Web.Optimization.Scripts.Render("~/Scripts/Filter.js") %>
</asp:Content>
