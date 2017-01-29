<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PsychologyHomework.aspx.cs" Inherits="MyNotebooks.Notebooks.Homework.PsychologyHomework" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="Psychology" Type="Homework" NotebookType="Домашна работа:" NotebookTitle="психология и логика"/>
</asp:Content>