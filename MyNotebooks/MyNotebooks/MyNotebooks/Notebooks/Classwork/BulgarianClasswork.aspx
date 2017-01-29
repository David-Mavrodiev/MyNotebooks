<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="BulgarianClasswork.aspx.cs" Inherits="MyNotebooks.Notebooks.Classwork.BulgarianClasswork" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="Bulgarian" Type="Classwork" NotebookType="Работа в клас:" NotebookTitle="български език и литература"/>
</asp:Content>