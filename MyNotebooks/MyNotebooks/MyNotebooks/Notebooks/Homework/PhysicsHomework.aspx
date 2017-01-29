<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PhysicsHomework.aspx.cs" Inherits="MyNotebooks.Notebooks.Homework.PhysicsHomework" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="Physics" Type="Homework" NotebookType="Домашна работа:" NotebookTitle="физика"/>
</asp:Content>