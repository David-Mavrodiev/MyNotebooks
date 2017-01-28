<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="History.aspx.cs" Inherits="MyNotebooks.Notebooks.History" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2 class="text-center">Тетрадка по история и цивилизации</h2>
        <div class="container">
            <div class="row">
                <h3 class="text-center">Оттук можете да изберете тетрадката, която ви трябва.</h3>
                <div class="col-md-8 col-md-offset-4">
                    <img src="../Images/History.jpg" class="img-rounded carousel-imageSize" alt="">
                    <br>
                    <a href="Classwork/HistoryClasswork" class="btn-lg btn-primary cursorDefault">Работа в клас</a>
                    <a href="Homework/HistoryHomework" class="btn-lg btn-primary cursorDefault">Домашна работа</a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
