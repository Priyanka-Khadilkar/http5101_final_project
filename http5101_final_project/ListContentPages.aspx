<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListContentPages.aspx.cs" Inherits="http5101_final_project.ListContentPages" %>

<asp:Content ID="list_contentpages" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="add_content_button" OnClick="add_content_button_Click" CssClass="floatright btn btn-primary topmargin " runat="server" Text="Add Content Page" />
    <div class="panel panel-primary top">
        <div class="panel-heading header-color">
            Content Pages
        </div>
        <div class="panel-body">
            <div class="marginbottom">
                <asp:TextBox ID="search_keyword" placeholder="Search.." runat="server"></asp:TextBox>
                <asp:Button ID="search_btn" OnClick="search_btn_Click" CssClass="btn btn-success" runat="server" Text="Search" />
            </div>
            <asp:GridView ID="contentpages_list_gridview" CssClass="table table-hover table-striped" runat="server" GridLines="None"
                AutoGenerateColumns="false" OnRowCommand="contentpages_list_gridview_RowCommand">
                <Columns>
                    <asp:BoundField DataField="Title" HeaderText="Title" />
                    <asp:BoundField DataField="PublishDate" DataFormatString="{0:yyyy/MM/dd}" HeaderText="Published Date" />
                    <asp:TemplateField ShowHeader="false">
                        <ItemTemplate>
                            <asp:Button ID="teacher_view_action" runat="server" CausesValidation="false" CssClass="btn btn-success" CommandName="view_contentpage"
                                Text="View" CommandArgument='<%# Eval("Id") %>' />
                            <asp:Button ID="teacher_edit_action" runat="server" CausesValidation="false" CssClass="btn btn-success" CommandName="edit_contentpage"
                                Text="Edit" CommandArgument='<%# Eval("Id") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
