<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PsychologyClasswork.aspx.cs" Inherits="MyNotebooks.Notebooks.Classwork.PsychologyClasswork" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="Psychology" Type="Classwork" NotebookType="Работа в клас:" NotebookTitle="психология и логика"/>
</asp:Content>