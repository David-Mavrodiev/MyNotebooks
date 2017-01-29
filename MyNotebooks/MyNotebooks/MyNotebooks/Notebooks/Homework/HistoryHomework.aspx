<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="HistoryHomework.aspx.cs" Inherits="MyNotebooks.Notebooks.Homework.HistoryHomework" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="History" Type="Homework" NotebookType="Домашна работа:" NotebookTitle="история и цивилизации"/>
</asp:Content>