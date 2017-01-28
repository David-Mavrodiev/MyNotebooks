<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Bulgarian.aspx.cs" Inherits="MyNotebooks.Notebooks.Bulgarian" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2 class="text-center">Тетрадка по български език и литература</h2>
        <div class="container">
            <div class="row">
                <h3 class="text-center">Оттук можете да изберете тетрадката, която ви трябва.</h3>
                <div class="col-md-8 col-md-offset-4">
                    <img src="../Images/Bulgarian.jpg" class="img-rounded carousel-imageSize" alt="">
                    <br>
                    <a href="Classwork/BulgarianClasswork" class="btn-lg btn-primary cursorDefault">Работа в клас</a>
                    <a href="Homework/BulgarianHomework" class="btn-lg btn-primary cursorDefault">Домашна работа</a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>