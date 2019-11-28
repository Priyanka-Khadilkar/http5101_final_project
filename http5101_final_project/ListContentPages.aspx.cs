using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace http5101_final_project
{
    public partial class ListContentPages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Create connection to database
                CMSDB db = new CMSDB();

                //Bind Gridview with data
                contentpages_list_gridview.DataSource = db.ListContentPages();
                contentpages_list_gridview.DataBind();
            }
        }

        protected void contentpages_list_gridview_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //Redirect to content page detail
            if (e.CommandName == "view_contentpage")
            {
                Response.Redirect("ViewContentPage.aspx?id=" + e.CommandArgument.ToString());
            }
            //Redirect to content page editing
            else if (e.CommandName == "edit_contentpage")
            {
                Response.Redirect("EditContentPage.aspx?id=" + e.CommandArgument.ToString());
            }

        }

        protected void add_content_button_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateContentPage.aspx");
        }

        protected void search_btn_Click(object sender, EventArgs e)
        {
            //Create connection to database
            CMSDB db = new CMSDB();

            //store the search keyword in variable
            string Search_Keywords = search_keyword.Text.Trim();

            //Bind Gridview after searching
            contentpages_list_gridview.DataSource = db.SearchContentPagesByPageTitle(Search_Keywords);
            contentpages_list_gridview.DataBind();

        }
    }
}