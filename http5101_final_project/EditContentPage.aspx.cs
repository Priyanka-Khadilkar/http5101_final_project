using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace http5101_final_project
{
    public partial class EditContentPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Fill details when Page loads for firsttime
            if (!Page.IsPostBack)
            {
                //Fill details in to controls.
                ShowContentPageDetail();
            }

        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListContentPages.aspx");
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {

            bool valid = true;
            string ContentPage_Id = Request.QueryString["id"];
            if (String.IsNullOrEmpty(ContentPage_Id)) valid = false;

            //We will attempt to update the record we need
            if (valid)
            {
                //create connection to cms database
                CMSDB db = new CMSDB();

                //create a new content page
                ContentPage ContentPage = new ContentPage();

                //set that content page data
                ContentPage.Title = contentpage_title.Text.Trim();
                ContentPage.Body = contentpage_body.Text.Trim();
                ContentPage.PublishDate = DateTime.Now;

                //update the content page to the database
                db.UpdateContentPage(Convert.ToInt32(ContentPage_Id), ContentPage);

                Response.Redirect("ListContentPages.aspx");
            }
            else
            { valid = false; }

            if (!valid)
            {
                contentpage_body_panel.InnerHtml = "There was an error finding that Content Page.";
            }

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
                contentpage_title.Text = ContentPage_Record.Title;
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