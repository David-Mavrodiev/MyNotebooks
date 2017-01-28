<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Informatics.aspx.cs" Inherits="MyNotebooks.Notebooks.Informatics" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2 class="text-center">Тетрадка по информатика</h2>
        <div class="container">
            <div class="row">
                <h3 class="text-center">Оттук можете да изберете тетрадката, която ви трябва.</h3>
                <div class="col-md-8 col-md-offset-4">
                    <img src="../Images/Informatics.jpg" class="img-rounded carousel-imageSize" alt="">
                    <br>
                    <a href="Classwork/InformaticsClasswork" class="btn-lg btn-primary cursorDefault">Работа в клас</a>
                    <a href="Homework/InformaticsHomework" class="btn-lg btn-primary cursorDefault">Домашна работа</a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
