using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace http5101_final_project
{
    public class ContentPage
    {

        //private fields for content page
        private string Title;
        private string Body;

        //return the private content of page title
        public string GetPageTitle()
        {
            return Title;
        }

        //return the private content of page body
        public string GetPageBody()
        {
            return Body;
        }

        //set the value of private content of page title
        public void SetPageTitle(string value)
        {
            Title = value;
        }

        //set the value of private content of page title
        public void SetPageBody(string value)
        {
            Body = value;
        }


    }
}