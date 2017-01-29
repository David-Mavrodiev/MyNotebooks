<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PhysicsClasswork.aspx.cs" Inherits="MyNotebooks.Notebooks.Classwork.PhysicsClasswork" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="Physics" Type="Classwork" NotebookType="Работа в клас:" NotebookTitle="физика"/>
</asp:Content>