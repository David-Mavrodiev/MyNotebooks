<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="BiologyHomework.aspx.cs" Inherits="MyNotebooks.Notebooks.Homework.BiologyHomework" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="Biology" Type="Homework" NotebookType="Домашна работа:" NotebookTitle="биология"/>
</asp:Content>