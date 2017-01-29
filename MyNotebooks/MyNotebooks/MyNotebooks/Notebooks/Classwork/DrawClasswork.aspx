<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="DrawClasswork.aspx.cs" Inherits="MyNotebooks.Notebooks.Classwork.DrawClasswork" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="Draw" Type="Classwork" NotebookType="Работа в клас:" NotebookTitle="изобразително изкуство"/>
</asp:Content>