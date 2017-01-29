<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="MusicHomework.aspx.cs" Inherits="MyNotebooks.Notebooks.Homework.MusicHomework" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="Music" Type="Homework" NotebookType="Домашна работа:" NotebookTitle="музика"/>
</asp:Content>