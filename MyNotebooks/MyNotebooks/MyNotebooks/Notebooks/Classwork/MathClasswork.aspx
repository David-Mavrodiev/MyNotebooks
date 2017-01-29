<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="MathClasswork.aspx.cs" Inherits="MyNotebooks.Notebooks.Classwork.MathClasswork" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="Math" Type="Classwork" NotebookType="Работа в клас:" NotebookTitle="математика"/>
</asp:Content>