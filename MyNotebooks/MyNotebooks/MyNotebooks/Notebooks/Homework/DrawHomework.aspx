<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="DrawHomework.aspx.cs" Inherits="MyNotebooks.Notebooks.Homework.DrawHomework" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="Draw" Type="Homework" NotebookType="Домашна работа:" NotebookTitle="изобразително изкуство"/>
</asp:Content>