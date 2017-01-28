<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyNotebooks._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <% for (int i = 0; i <= this.NumberOfNotebooks; i++){%>
                <% if (i == 0){ %>
                <li data-target="#myCarousel" data-slide-to="<%=i %>" class="active"></li>
                <%}else{ %>
                 <li data-target="#myCarousel" data-slide-to="<%=i%>"></li>
                <%} %>

            <%}%>
        </ol>
        <!-- Wrapper for slides -->
        <div class="carousel-inner" role="listbox">
            <%for (int i = 0; i < this.NumberOfNotebooks; i++) { %>
                <% if (i == 0) { %>
                     <div class="item active carousel-wrapper">
                        <img class="carousel-imageSize" src="<%= this.GetImages.ElementAt(i).Value %>" alt="<%= this.GetImages.ElementAt(i).Key %>">
                     </div>
                <%}else{ %>
                    <div class="item carousel-wrapper">
                        <img class="carousel-imageSize" src="<%= this.GetImages.ElementAt(i).Value %>" alt="<%= this.GetImages.ElementAt(i).Key %>">
                     </div>
                <%} %>
            <%} %>
        </div>

        <!-- Left and right controls -->
        <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>
    <div style="border-radius: 2px; background-color: darkseagreen" id="about" runat="server" class="jumbotron">
        <section class="success">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12 text-center">
                        <h1>About</h1>
                        <hr class="star-light">
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-4 col-lg-offset-2">
                        <h3>Freelancer is a free bootstrap theme created by Start Bootstrap. The download includes the complete source files including HTML, CSS, and JavaScript as well as optional LESS stylesheets for easy customization.</h3>
                    </div>
                    <div class="col-lg-4">
                        <h3>Whether you're a student looking to showcase your work, a professional looking to attract clients, or a graphic artist looking to share your projects, this template is the perfect starting point!</h3>
                    </div>
                </div>
            </div>
        </section>
    </div>
    <div id="notebooks" class="jumbotron" runat="server">
        <h1 class="text-center">Моите <span class="logo">е</span>-тетрадки</h1>
        <div class="row">
            <%for (int i = 0; i < this.NumberOfNotebooks; i++) { %>
                <div class="col-md-4">
                    <div class="thumbnail">
                        <a href="<%=this.GetNotebooks.ElementAt(i).Value %>">
                            <img class="notebook-imageSize" src="<%=this.GetImages.ElementAt(i).Value %>" alt="Lights">
                            <div class="caption">
                                <p class="text-center"><%=this.GetNotebooks.ElementAt(i).Key %></p>
                            </div>
                        </a>
                    </div>
                </div>
            <%} %>
        </div>
    </div>

</asp:Content>
