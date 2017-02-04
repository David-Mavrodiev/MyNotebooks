<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CheckNotebook.aspx.cs" Inherits="MyNotebooks.CheckNotebook" %>
<%@ Register Src="./Notebooks/Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Mode="Check" Type="Homework" NotebookType="Домашна работа:"/>
</asp:Content>
