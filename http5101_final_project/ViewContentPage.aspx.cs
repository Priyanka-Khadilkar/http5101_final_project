using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace http5101_final_project
{
    public partial class ViewContentPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowContentPageDetail();

        }

        protected void back_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListContentPages.aspx");
        }

        protected void ShowContentPageDetail()
        {
            bool valid = true;
            string ContentPage_Id = Request.QueryString["id"];
            if (String.IsNullOrEmpty(ContentPage_Id)) valid = false;

            //We will attempt to get the record we need
            if (valid)
            {
                CMSDB db = new CMSDB();
                ContentPage ContentPage_Record = db.GetContentPageById(Int32.Parse(ContentPage_Id));
                contentpage_title.InnerHtml = ContentPage_Record.Title;
                contentpage_body.Text = ContentPage_Record.Body;
            }
            else
            {
                valid = false;
            }

            if (!valid)
            {
                contentpage_body_panel.InnerHtml = "There was an error finding that Content Page.";
            }
        }
    }
}