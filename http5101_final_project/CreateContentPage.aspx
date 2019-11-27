<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateContentPage.aspx.cs" Inherits="http5101_final_project.CreateContentPage" %>

<asp:Content ID="create_page" ContentPlaceHolderID="MainContent" runat="server">
    <div class="panel panel-primary top">
        <div class="panel-heading">
            Create Page
        </div>
        <div class="panel-body">
            <div class="form-horizontal">
                <div class="form-group">
                    <label class="control-label col-sm-2">Page Title :</label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="page_title" placeholder="Enter page title" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="page_title" ForeColor="Red" ErrorMessage="Please Enter Page Title."></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-2">Page Body :</label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="page_body" TextMode="MultiLine" Columns="100" Rows="10" placeholder="Enter content of your page body" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="page_body" ForeColor="Red" ErrorMessage="Please Enter Content for Page Body."></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-offset-2 col-sm-10">
                        <asp:Button ID="btn_submit" CssClass="btn header-color" CausesValidation="true" runat="server" Text="Add" />
                        <asp:Button ID="btn_cancel" CssClass="btn header-color" CausesValidation="false" runat="server" Text="Clear" />
                        <asp:Button ID="btn_back" CssClass="btn header-color" CausesValidation="false" runat="server" Text="Back" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
