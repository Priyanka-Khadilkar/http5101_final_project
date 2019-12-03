using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace http5101_final_project
{
    public class ContentPage
    {
        //I am using Gridview for listing all content pages so i used public properties.

        //Title of the Content page
        public string Title { get; set; }

        //Body of the Content page
        public string Body { get; set; }

        //Id of the Content Page
        public int Id { get; set; }

        //Publish Date of content Page
        public DateTime PublishDate { get; set; }

        //Page is published or not
        public bool Is_Published { get; set; }


    }
}