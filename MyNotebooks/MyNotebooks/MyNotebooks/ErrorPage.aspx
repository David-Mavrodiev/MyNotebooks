<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ErrorPage.aspx.cs" Inherits="MyNotebooks.ErrorPage" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div id="errorPage" class="container" runat="server">
        <div class="row">
            <div class="col-md-12">
                <div class="error-template">
                    <h1>Oops!</h1>
                    <h2>404 Not Found</h2>
                    <div class="error-details">
                        Sorry, an error has occured, Requested page not found!
               
                    </div>
                    <div class="error-actions">
                        <a href="http://www.jquery2dotnet.com" class="btn btn-primary btn-lg"><span class="glyphicon glyphicon-home"></span>
                            Take Me Home </a><a href="http://www.jquery2dotnet.com" class="btn btn-default btn-lg"><span class="glyphicon glyphicon-envelope"></span>Contact Support </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
