<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Geography.aspx.cs" Inherits="MyNotebooks.Notebooks.Geography" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2 class="text-center">Тетрадка по география</h2>
        <div class="container">
            <div class="row">
                <h3 class="text-center">Оттук можете да изберете тетрадката, която ви трябва.</h3>
                <div class="col-md-8 col-md-offset-4">
                    <img src="../Images/Geography.jpg" class="img-rounded carousel-imageSize" alt="">
                    <br>
                    <a href="Classwork/GeographyClasswork" class="btn-lg btn-primary cursorDefault">Работа в клас</a>
                    <a href="Homework/GeographyHomework" class="btn-lg btn-primary cursorDefault">Домашна работа</a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
