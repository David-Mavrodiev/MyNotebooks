<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Music.aspx.cs" Inherits="MyNotebooks.Notebooks.Music" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2 class="text-center">Тетрадка по музика</h2>
        <div class="container">
            <div class="row">
                <h3 class="text-center">Оттук можете да изберете тетрадката, която ви трябва.</h3>
                <div class="col-md-8 col-md-offset-4">
                    <img src="../Images/Music.jpg" class="img-rounded carousel-imageSize" alt="">
                    <br>
                    <a href="Classwork/MusicClasswork" class="btn-lg btn-primary cursorDefault">Работа в клас</a>
                    <a href="Homework/MusicHomework" class="btn-lg btn-primary cursorDefault">Домашна работа</a>
                </div>
            </div>
        </div>
    </div> 
</asp:Content>