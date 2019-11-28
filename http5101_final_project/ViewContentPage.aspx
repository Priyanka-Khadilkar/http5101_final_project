<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewContentPage.aspx.cs" Inherits="http5101_final_project.ViewContentPage" %>

<asp:Content ID="view_contentpage" ContentPlaceHolderID="MainContent" runat="server">
    <div class="panel panel-primary top">
        <div class="panel-heading header-color">
            <span runat="server" id="contentpage_title"></span>
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
