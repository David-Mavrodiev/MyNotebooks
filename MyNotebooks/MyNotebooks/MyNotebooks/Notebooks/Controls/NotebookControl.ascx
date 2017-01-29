<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NotebookControl.ascx.cs" Inherits="MyNotebooks.Notebooks.Controls.NotebookControl" %>

<div class="jumbotron">
    <h2 class="text-center">Тетрадка по <%= this.NotebookTitle %></h2>
    <div class="container">
        <div class="row">
            <div class="form-group">
                <label for=" Email1msg"><%= this.NotebookType %></label>
                <br>
                <asp:TextBox TextMode="MultiLine" Rows="10" Columns="92" ID="TextContent" runat="server"></asp:TextBox>
            </div>
            <asp:Button ID="SaveButton" CssClass="btn-lg btn-primary cursorDefault" runat="server" Text="Запиши промените" />
        </div>
    </div>
</div>
