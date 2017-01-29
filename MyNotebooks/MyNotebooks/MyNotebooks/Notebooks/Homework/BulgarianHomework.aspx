<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="BulgarianHomework.aspx.cs" Inherits="MyNotebooks.Notebooks.Homework.BulgarianHomework" %>
<%@ Register Src="../Controls/NotebookControl.ascx" TagPrefix="uc" TagName="NotebookView" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <uc:NotebookView runat="server" Subject="Bulgarian" Type="Homework" NotebookType="Домашна работа:" NotebookTitle="български език и литература"/>
</asp:Content>