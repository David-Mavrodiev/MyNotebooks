<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Teachers.aspx.cs" Inherits="MyNotebooks.Teachers" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2 class="text-center">Учители</h2>
        <asp:Label ID="TeacherNameLabel" runat="server" Text="E-mail на учителя:"></asp:Label>
        <asp:TextBox ID="TeacherName" runat="server"></asp:TextBox>
        <asp:DropDownList ID="Subjects" runat="server">
        </asp:DropDownList>
        <asp:Button CssClass="btn-lg btn-primary" ID="AddButton" runat="server" Text="Добави" />
    </div>
    <div id="teachers" class="jumbotron" runat="server">
        <h3 class="text-center">Моите учители</h3>
        <div class="row">
            <%for (int i = 0; i < this.GetRelationships.Count; i++)
                { %>
            <div class="col-md-4">
                <div class="thumbnail">
                    <div class="caption">
                        <p class="text-center"><%=this.GetRelationships.ElementAt(i).Subject %></p>
                        <p class="text-center"><%=this.GetRelationships.ElementAt(i).TeacherName %></p>
                    </div>
                </div>
            </div>
            <%} %>
        </div>
    </div>
</asp:Content>
