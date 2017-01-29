<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="MathHomework.aspx.cs" Inherits="MyNotebooks.Notebooks.Homework.MathHomework" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="Math" Type="Homework" NotebookType="Домашна работа:" NotebookTitle="математика"/>
</asp:Content>