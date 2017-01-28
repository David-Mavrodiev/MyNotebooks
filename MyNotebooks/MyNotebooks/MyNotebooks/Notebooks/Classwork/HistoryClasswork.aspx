<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="HistoryClasswork.aspx.cs" Inherits="MyNotebooks.Notebooks.Classwork.HistoryClasswork" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2 class="text-center">Тетрадка по история и цивилизации</h2>
        <div class="container">
            <div class="row">
                <div class="form-group">
                    <label for=" Email1msg">Работа в клас:</label>
                    <br>
                    <asp:TextBox TextMode="MultiLine" Rows="10" Columns="92" ID="TextContent" runat="server"></asp:TextBox>
                </div>
                <asp:Button ID="SaveButton" CssClass="btn-lg btn-primary cursorDefault" runat="server" Text="Запиши промените" />
            </div>
        </div>
    </div>
</asp:Content>