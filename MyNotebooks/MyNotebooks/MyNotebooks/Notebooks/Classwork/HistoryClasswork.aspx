<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="HistoryClasswork.aspx.cs" Inherits="MyNotebooks.Notebooks.Classwork.HistoryClasswork" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="History" Type="Classwork" NotebookType="Работа в клас:" NotebookTitle="история и цивилизации"/>
</asp:Content>