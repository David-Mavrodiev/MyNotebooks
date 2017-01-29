<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="InformaticsHomework.aspx.cs" Inherits="MyNotebooks.Notebooks.Homework.InformaticsHomework" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="Informatics" Type="Homework" NotebookType="Домашна работа:" NotebookTitle="информатика"/>
</asp:Content>