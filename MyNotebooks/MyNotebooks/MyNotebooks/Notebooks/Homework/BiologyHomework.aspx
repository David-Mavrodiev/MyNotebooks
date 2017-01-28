﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="BiologyHomework.aspx.cs" Inherits="MyNotebooks.Notebooks.Homework.BiologyHomework" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2 class="text-center">Тетрадка по биология</h2>
        <div class="container">
            <div class="row">
                <div class="form-group">
                    <label for=" Email1msg">Домашна работа:</label>
                    <br>
                    <asp:TextBox TextMode="MultiLine" Rows="10" Columns="92" ID="TextContent" runat="server"></asp:TextBox>
                </div>
                <asp:Button ID="SaveButton" CssClass="btn-lg btn-primary cursorDefault" runat="server" Text="Запиши промените" />
            </div>
        </div>
    </div>
</asp:Content>