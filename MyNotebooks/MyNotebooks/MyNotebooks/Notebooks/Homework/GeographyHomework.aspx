<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="GeographyHomework.aspx.cs" Inherits="MyNotebooks.Notebooks.Homework.GeographyHomework" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="Geography" Type="Homework" NotebookType="Домашна работа:" NotebookTitle="география и икономика"/>
</asp:Content>