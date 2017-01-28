<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="English.aspx.cs" Inherits="MyNotebooks.Notebooks.English" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2 class="text-center">Тетрадка по английски език</h2>
        <div class="container">
            <div class="row">
                <h3 class="text-center">Оттук можете да изберете тетрадката, която ви трябва.</h3>
                <div class="col-md-8 col-md-offset-4">
                    <img src="../Images/English.jpg" class="img-rounded carousel-imageSize" alt="">
                    <br>
                    <a href="Classwork/EnglishClasswork" class="btn-lg btn-primary cursorDefault">Работа в клас</a>
                    <a href="Homework/EnglishHomework" class="btn-lg btn-primary cursorDefault">Домашна работа</a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
