using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace http5101_final_project
{
    public class CMSDB
    {
        //user of the database
        private static string User { get { return "root"; } }

        //password of the database
        private static string Password { get { return ""; } }

        //Name of database
        private static string Database { get { return "cms"; } }

        //Server of database
        private static string Server { get { return "localhost"; } }

        //Port of the database
        private static string Port { get { return "3306"; } }

        //Connection string to connect database
        private static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                    + "; password = " + Password;
            }
        }

        /// <summary>
        /// Add new content page
        /// </summary>
        /// <param name="new_contentpage"></param>
        public void AddContentPage(ContentPage new_contentpage)
        {
            //Query for inserting data into database
            string query = "insert into content_pages (pagetitle, pagebody, publishdate) values ('{0}','{1}','{2}')";
            query = String.Format(query, new_contentpage.Title, new_contentpage.Body, new_contentpage.PublishDate.ToString("yyyy-MM-dd"));

            //DB connection
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                //Execute query to insert data into database
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //track errors and exception in debug window
                Debug.WriteLine("Something went wrong in the AddContentPage Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }

        /// <summary>
        /// List of all content pages
        /// </summary>
        /// <returns></returns>
        public List<ContentPage> ListContentPages()
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);

            //Create a blank list of contentpages
            List<ContentPage> ContentPages_List = new List<ContentPage>();

            try
            {
                //Query for fetching all data
                string query = "select * from content_pages";

                //open the db connection
                Connect.Open();

                //Run out query 
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                //grab the result set
                MySqlDataReader resultset = cmd.ExecuteReader();

                //read through the result set
                while (resultset.Read())
                {
                    //information that will store a single content page
                    ContentPage Current_ContentPage = new ContentPage();

                    //Look at each column in the result set row, add both the column name and the column value to our Content page dictionary
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        string key = resultset.GetName(i);
                        string value = resultset.GetString(i);

                        switch (key)
                        {
                            case "page_id":
                                Current_ContentPage.Id = Convert.ToInt32(value);
                                break;
                            case "pagetitle":
                                Current_ContentPage.Title = value;
                                break;
                            case "pagebody":
                                Current_ContentPage.Body = value;
                                break;
                            case "publishdate":
                                Current_ContentPage.PublishDate = Convert.ToDateTime(value);
                                break;

                        }

                    }
                    //Add the content page to the list of content pages
                    ContentPages_List.Add(Current_ContentPage);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the List Content Pages method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
            return ContentPages_List;
        }

        /// <summary>
        /// Update Content page
        /// </summary>
        /// <param name="contentpage_id">Id of content page</param>
        /// <param name="new_contentpage">Object of Content</param>
        public void UpdateContentPage(int contentpage_id, ContentPage new_contentpage)
        {
            //Query for inserting data into database
            string query = "update content_pages set pagetitle='{0}', pagebody='{1}', publishdate='{2}' where page_id = {3}";
            query = String.Format(query, new_contentpage.Title, new_contentpage.Body, new_contentpage.PublishDate, contentpage_id);

            //DB connection
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                //Execute query to insert data into database
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //track errors and exception in debug window
                Debug.WriteLine("Something went wrong in the AddContentPage Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }

        /// <summary>
        /// Delete Content page
        /// </summary>
        /// <param name="contentpage_id">Id of content page</param>
        public void DeleteContentPage(int contentpage_id)
        {
            //Query for inserting data into database
            string query = "delete from content_pages where page_id = {0}";
            query = String.Format(query, contentpage_id);

            //DB connection
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                //Execute query to insert data into database
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //track errors and exception in debug window
                Debug.WriteLine("Something went wrong in the AddContentPage Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }

        /// <summary>
        /// Get content page detail by id.
        /// </summary>
        /// <param name="contentpage_id">Id of content page</param>
        /// <returns></returns>
        public ContentPage GetContentPageById(int contentpage_id)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);

            //Create a blank list of contentpages
            ContentPage Result_ContentPage = new ContentPage();
            try
            {
                //Query for fetching all data
                string query = "select * from content_pages where page_id = {0}";
                query = String.Format(query, contentpage_id);

                //open the db connection
                Connect.Open();

                //Run out query 
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                //grab the result set
                MySqlDataReader resultset = cmd.ExecuteReader();

                List<ContentPage> ContentPages = new List<ContentPage>();

                //read through the result set
                while (resultset.Read())
                {
                    //information that will store a single content page
                    ContentPage Current_ContentPage = new ContentPage();

                    //Look at each column in the result set row, add both the column name and the column value to our Content page dictionary
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        string key = resultset.GetName(i);
                        string value = resultset.GetString(i);

                        switch (key)
                        {
                            case "page_id":
                                Current_ContentPage.Id = Convert.ToInt32(value);
                                break;
                            case "pagetitle":
                                Current_ContentPage.Title = value;
                                break;
                            case "pagebody":
                                Current_ContentPage.Body = value;
                                break;
                            case "publishdate":
                                Current_ContentPage.PublishDate = Convert.ToDateTime(value);
                                break;

                        }

                    }
                    //Add the content page to the list of content pages
                    ContentPages.Add(Current_ContentPage);
                }

                Result_ContentPage = ContentPages[0]; //get the first content page

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the List Content Pages method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
            return Result_ContentPage;
        }

        /// <summary>
        /// List of all content pages
        /// </summary>
        /// <returns></returns>
        public List<ContentPage> SearchContentPagesByPageTitle(string search_keyword)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);

            //Create a blank list of contentpages
            List<ContentPage> ContentPages_List = new List<ContentPage>();

            try
            {
                string query = "";
                //Query for fetching all data with search keyword
                if (string.IsNullOrEmpty(search_keyword))
                {
                    query = "select * from content_pages";
                }
                else
                {
                    query = "select * from content_pages where pagetitle like '%{0}%'";
                    query = String.Format(query, search_keyword);
                }

                //open the db connection
                Connect.Open();

                //Run out query 
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                //grab the result set
                MySqlDataReader resultset = cmd.ExecuteReader();

                //read through the result set
                while (resultset.Read())
                {
                    //information that will store a single content page
                    ContentPage Current_ContentPage = new ContentPage();

                    //Look at each column in the result set row, add both the column name and the column value to our Content page dictionary
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        string key = resultset.GetName(i);
                        string value = resultset.GetString(i);

                        switch (key)
                        {
                            case "page_id":
                                Current_ContentPage.Id = Convert.ToInt32(value);
                                break;
                            case "pagetitle":
                                Current_ContentPage.Title = value;
                                break;
                            case "pagebody":
                                Current_ContentPage.Body = value;
                                break;
                            case "publishdate":
                                Current_ContentPage.PublishDate = Convert.ToDateTime(value);
                                break;

                        }

                    }
                    //Add the content page to the list of content pages
                    ContentPages_List.Add(Current_ContentPage);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the Search ContentPages By PageTitle method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
            return ContentPages_List;
        }


    }
}