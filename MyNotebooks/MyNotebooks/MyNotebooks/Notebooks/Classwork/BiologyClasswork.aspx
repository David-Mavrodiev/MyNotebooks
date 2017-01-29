<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="BiologyClasswork.aspx.cs" Inherits="MyNotebooks.Notebooks.Classwork.BiologyClasswork" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="Biology" Type="Classwork" NotebookType="Работа в клас:" NotebookTitle="биология"/>
</asp:Content>