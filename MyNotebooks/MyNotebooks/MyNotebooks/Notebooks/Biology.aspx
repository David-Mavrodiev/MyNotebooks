<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Biology.aspx.cs" Inherits="MyNotebooks.Notebooks.Biology" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2 class="text-center">Тетрадка по биология</h2>
        <div class="container">
            <div class="row">
                <h3 class="text-center">Оттук можете да изберете тетрадката, която ви трябва.</h3>
                <div class="col-md-8 col-md-offset-4">
                    <img src="../Images/Biology.jpg" class="img-rounded carousel-imageSize" alt="">
                    <br>
                    <a href="Classwork/BiologyClasswork" class="btn-lg btn-primary cursorDefault">Работа в клас</a>
                    <a href="Homework/BiologyHomework" class="btn-lg btn-primary cursorDefault">Домашна работа</a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>