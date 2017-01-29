<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="EnglishHomework.aspx.cs" Inherits="MyNotebooks.Notebooks.Homework.EnglishHomework" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="English" Type="Homework" NotebookType="Домашна работа:" NotebookTitle="английски език"/>
</asp:Content>