<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditContentPage.aspx.cs" Inherits="http5101_final_project.EditContentPage" %>

<asp:Content ID="edit_contentpage" ContentPlaceHolderID="MainContent" runat="server">
    <div class="panel panel-primary top">
        <div class="panel-heading header-color">
            Edit Content Page
        </div>
        <div class="panel-body" id="contentpage_body_panel" runat="server">
            <div class="form-horizontal">
                <div class="form-group">
                    <label class="control-label col-sm-2">Page Title :</label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="contentpage_title" MaxLength="100" placeholder="Enter page title" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="contentpage_title" ForeColor="Red" ErrorMessage="Please Enter Page Title."></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-2">Page Body :</label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="contentpage_body" TextMode="MultiLine" Columns="100" Rows="10" placeholder="Enter content of your page body" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="contentpage_body" ForeColor="Red" ErrorMessage="Please Enter Content for Page Body."></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-offset-2 col-sm-10">
                        <asp:Button ID="btn_submit" OnClick="btn_submit_Click" CssClass="btn btn-success" CausesValidation="true" runat="server" Text="Edit" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="form-group row">
        <div class="col-sm-10">
            <asp:Button ID="btn_back" CssClass="btn header-color" OnClick="btn_back_Click" CausesValidation="false" runat="server" Text="Back" />
        </div>
    </div>
</asp:Content>
