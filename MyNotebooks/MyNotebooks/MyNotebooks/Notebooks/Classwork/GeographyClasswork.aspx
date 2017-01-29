<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="GeographyClasswork.aspx.cs" Inherits="MyNotebooks.Notebooks.Classwork.GeographyClasswork" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="Geography" Type="Classwork" NotebookType="Работа в клас:" NotebookTitle="география и икономика"/>
</asp:Content>