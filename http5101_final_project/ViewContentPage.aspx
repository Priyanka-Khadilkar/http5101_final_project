<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewContentPage.aspx.cs" Inherits="http5101_final_project.ViewContentPage" %>

<asp:Content ID="view_contentpage" ContentPlaceHolderID="MainContent" runat="server">
    <div class="panel panel-primary top">
        <div class="panel-heading header-color">
            <span runat="server" id="contentpage_title"></span>
            <div class="float-right">
                <asp:LinkButton ID="delete_contentpage" OnClientClick="if(!confirm('Are you sure you want to delete this?')) return false;" CssClass="padding-right" ToolTip="Delete Content Page" OnClick="delete_contentpage_Click" runat="server"><span class="glyphicon glyphicon-trash deletebtn"></span></asp:LinkButton>
                <asp:LinkButton ID="edit_contentpage" ToolTip="Edit Content Page" OnClick="edit_contentpage_Click" runat="server"><span class="glyphicon glyphicon-edit deletebtn"></span></asp:LinkButton>
            </div>
        </div>
        <div id="contentpage_body_panel" runat="server" class="panel-body">
            <div runat="server" id="teacher_detail">
                <div class="form-group row">
                    <div class="col-sm-10">
                        <asp:Label ID="contentpage_body" runat="server"></asp:Label>
                    </div>
                </div>

            </div>
        </div>
    </div>
    <div class="form-group row">
        <div class="col-sm-10">
            <asp:Button CssClass="btn header-color" ID="back_btn" OnClick="back_btn_Click" runat="server" Text="Back" />
        </div>
    </div>
</asp:Content>
