<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ChemistryHomework.aspx.cs" Inherits="MyNotebooks.Notebooks.Homework.ChemistryHomework" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="Chemistry" Type="Homework" NotebookType="Домашна работа:" NotebookTitle="химия"/>
</asp:Content>