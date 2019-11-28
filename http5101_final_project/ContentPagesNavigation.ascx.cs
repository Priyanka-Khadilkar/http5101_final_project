﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace http5101_final_project
{
    public partial class ContentPagesNavigation : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CMSDB db = new CMSDB();
            ListNavigationContentPages(db);

        }
        private void ListNavigationContentPages(CMSDB db)
        {

            List<ContentPage> ContentPage_List = new List<ContentPage>();
            ContentPage_List = db.ListContentPages();

            foreach (ContentPage page in ContentPage_List)
            {
                string url = "<li><a href='ViewContentPage.aspx?id={0}'>{1}</a></li>";
                url = string.Format(url, page.Id, page.Title);
                header_nav.InnerHtml += url;

            }

        }
    }
}