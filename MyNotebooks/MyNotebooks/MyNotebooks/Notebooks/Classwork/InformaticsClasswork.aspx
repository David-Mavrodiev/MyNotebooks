<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="InformaticsClasswork.aspx.cs" Inherits="MyNotebooks.Notebooks.Classwork.InformaticsClasswork" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="Informatics" Type="Classwork" NotebookType="Работа в клас:" NotebookTitle="информатика"/>
</asp:Content>