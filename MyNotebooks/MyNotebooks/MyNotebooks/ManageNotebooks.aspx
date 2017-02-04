<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ManageNotebooks.aspx.cs" Inherits="MyNotebooks.ManageNotebooks" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div style="border-radius: 2px;" id="about" runat="server" class="jumbotron">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2>Тетрадки</h2>
                    <hr class="star-light">
                </div>
            </div>
        </div>
    </div>
    <div class="jumbotron">
        <div class="row">
            <% for (int i = 0; i < this.GetNotebooks.Count; i++)
                { %>
            <div class="col-md-4">
                <a href="/CheckNotebook?studentName=<%= this.GetNotebooks.ElementAt(i).StudentName%>&Subject=<%=this.Titles.FirstOrDefault(n => n.Key == this.GetNotebooks.ElementAt(i).Subject).Value  %>&Bg=<%= this.GetNotebooks.ElementAt(i).Subject %>">
                    <div class="thumbnail">
                        <div class="caption">
                            <p class="text-center"><%=this.GetNotebooks.ElementAt(i).Subject %></p>
                            <p class="text-center"><%=this.GetNotebooks.ElementAt(i).StudentName %></p>
                        </div>
                    </div>
                </a>
            </div>
            <%} %>
        </div>
    </div>
</asp:Content>
