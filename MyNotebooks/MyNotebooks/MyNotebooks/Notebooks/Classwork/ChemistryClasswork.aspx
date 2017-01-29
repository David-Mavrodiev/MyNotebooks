<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ChemistryClasswork.aspx.cs" Inherits="MyNotebooks.Notebooks.Classwork.ChemistryClasswork" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="Chemistry" Type="Classwork" NotebookType="Работа в клас:" NotebookTitle="химия"/>
</asp:Content>