<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="MusicClasswork.aspx.cs" Inherits="MyNotebooks.Notebooks.Classwork.MusicClasswork" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="Music" Type="Classwork" NotebookType="Работа в клас:" NotebookTitle="музика"/>
</asp:Content>