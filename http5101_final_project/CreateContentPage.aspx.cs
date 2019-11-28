using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace http5101_final_project
{
    public partial class CreateContentPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            //create connection to cms database
            CMSDB db = new CMSDB();

            //create a new content page
            ContentPage ContentPage = new ContentPage();
            //set that student data
            ContentPage.Title = contentpage_title.Text.Trim();
            ContentPage.Body = contentpage_body.Text.Trim();

            //add the content page to the database
            db.AddContentPage(ContentPage);

            Response.Redirect("ListContentPages.aspx");
        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            contentpage_title.Text = string.Empty;
            contentpage_body.Text = string.Empty;
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListContentPages.aspx");
        }
    }
}