<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="EnglishClasswork.aspx.cs" Inherits="MyNotebooks.Notebooks.Classwork.EnglishClasswork" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="English" Type="Classwork" NotebookType="Работа в клас:" NotebookTitle="английски език"/>
</asp:Content>