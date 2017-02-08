<%@ Page Title="Manage Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="MyNotebooks.Account.Manage" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="text-center">Моят акаунт</h2>
    <div>
        <asp:PlaceHolder runat="server" ID="successMessage" Visible="false" ViewStateMode="Disabled">
            <p class="text-success"><%: SuccessMessage %></p>
        </asp:PlaceHolder>
    </div>

     <div class="container">
	<div class="row">
		<div class="col-md-offset-2 col-md-8 col-lg-offset-3 col-lg-6">
    	 <div class="well profile">
            <div class="col-sm-12">
                <div class="col-xs-12 col-sm-8">
                    <h2><%=User.Identity.Name %></h2>
                    <p><strong>Роля: </strong>
                        <span class="tags"><%=User.IsInRole("Teacher")? "Учител" : "Ученик" %></span> 
                    </p>
                    <p><strong>Брой външни логини: </strong>
                        <span class="tags"><%= LoginsCount %></span> 
                    </p>
                </div>             
                <div class="col-xs-12 col-sm-4 text-center">
                    <figure>
                        <img class="img-circle img-responsive profile-image" src="<%=Request.ApplicationPath + "Uploaded_Files/" + Context.User.Identity.GetUserName() + ".png"  %>"/>
                        <figcaption class="ratings">
                            <p>Профилна снимка</p>
                        </figcaption>
                    </figure>
                </div>
            </div>            
            <div class="col-xs-12 divider text-center">
                <div class="col-xs-12 col-sm-4 emphasis">
                    <h2><strong>Опции</strong></h2>                    
                    <p><small>на акаунта</small></p>
                    <div class="btn-group dropup btn-block">
                      <button type="button" class="btn btn-primary"><span class="fa fa-gear"></span> Опции </button>
                      <button type="button" class="btn btn-primary dropdown-toggle" data-toggle="dropdown">
                        <span class="caret"></span>
                        <span class="sr-only">Toggle Dropdown</span>
                      </button>
                      <ul class="dropdown-menu text-left" role="menu">
                        <li class="divider"></li>
                        <li><asp:HyperLink NavigateUrl="/Account/ManagePassword" Text="Промяна на паролата" Visible="false" ID="ChangePassword" runat="server" /></li>
                        <li class="divider"></li>
                        <li><asp:HyperLink NavigateUrl="/Account/ManageLogins" Text="Добави/Премахни външни логини" runat="server" /></li>
                        <li class="divider"></li>
                        <asp:HyperLink NavigateUrl="/Account/ManagePassword" Text="[Create]" Visible="false" ID="CreatePassword" runat="server" />                      
                      </ul>
                    </div>
                </div>
            </div>
    	 </div>                 
		</div>
	</div>
</div>
</asp:Content>
