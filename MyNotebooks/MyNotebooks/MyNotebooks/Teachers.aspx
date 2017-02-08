<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Teachers.aspx.cs" Inherits="MyNotebooks.Teachers" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2 class="text-center">Учители</h2>
        <asp:Label ID="TeacherNameLabel" runat="server" Text="E-mail на учителя:"></asp:Label>
        <asp:TextBox ID="TeacherName" runat="server"></asp:TextBox>
        <div style="width: 250px; display: inline-block">
            <asp:DropDownList ID="Subjects" runat="server" CssClass="form-control DisplayInline">
            </asp:DropDownList>
        </div>
        <asp:Button CssClass="btn-lg btn-primary" ID="AddButton" runat="server" Text="Добави" />
    </div>
    <div id="teachers" class="jumbotron" runat="server">
        <%if (this.GetRelationships.Count <= 0) { %>
            <h3 style="color: red" class="text-center">За съжаление, до този момент не сте посочили учители!</h3>
        <%}else{%>
            <h3 class="text-center">Моите учители</h3>
        <%} %>
        <div class="row">
            <%for (int i = 0; i < this.GetRelationships.Count; i++)
                { %>
            <div class="col-md-4">
                <div class="thumbnail">
                    <img style="width: 200px; height: 200px;" class="img-circle img-responsive profile-image" src="<%=Request.ApplicationPath + "Uploaded_Files/" + this.GetRelationships.ElementAt(i).TeacherName + ".png"  %>"/>
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
